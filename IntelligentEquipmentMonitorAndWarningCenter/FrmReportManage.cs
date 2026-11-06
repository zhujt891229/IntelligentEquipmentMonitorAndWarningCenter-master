using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;
using IEMAWC.BLL;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;
using NPOI.SS.UserModel;
using static NPOI.HSSF.Util.HSSFColor;

namespace IntelligentDeviceMonitorAndWarningCenter
{
    public partial class FrmReportManage : Form
    {
        private ReportBLL reportBLL = new ReportBLL();
        //数据实时刷新
        private AlarmDataManager _dataManager;
        private int pageSize = 20; // 默认每页20条

        public FrmReportManage()
        {
            InitializeComponent();

            // 绑定 UPager 的分页事件
            pager.PageChanged += Pager_PageChanged;
            pager.PageSize = pageSize;

            // 实例化数据管理器
            _dataManager = new AlarmDataManager();
            // 订阅数据更新事件
            _dataManager.OnDataUpdated += UpdateUI;

        }

        private void FrmReportManage_Load(object sender, EventArgs e)
        {
            // 初始化下拉框
            cboReportTypes.Items.Clear();
            cboReportTypes.Items.Add("日报表");
            cboReportTypes.Items.Add("周报表");
            cboReportTypes.Items.Add("月报表");
            cboReportTypes.SelectedIndex = 0;

            // 初始化时间控件
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.CustomFormat = "yyyy-MM-dd";

            // 默认选中异常报表
            rbtnAlarm.Checked = true;
            LoadAllData();
            // 窗体加载时获取数据
            _dataManager.RefreshData();
        }
      

        // ============ 点击“统计”按钮 ============
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            pager.PageIndex = 1; // 重新统计时重置为第一页
            LoadAllData();
        }

        // ============ 核心加载数据逻辑 ============
        private void LoadAllData()
        {
            try
            {
                bool isAlarmReport = rbtnAlarm.Checked; // rbtnAlarm 为 true 是异常报表，false 是实时数据
                string reportType = cboReportTypes.Text;
                string queryDate = dtTime.Value.ToString("yyyy-MM-dd");

                // 1. 获取总记录数并更新 UPager 控件
                int totalCount = reportBLL.GetTotalCount(isAlarmReport, reportType, queryDate);
                pager.PageSize = pageSize;
                pager.TotalCount = totalCount;

                // 2. 加载表格数据
                LoadGridData(isAlarmReport, reportType, queryDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("加载数据失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 分离表格加载逻辑，方便翻页时调用
        private void LoadGridData(bool isAlarmReport, string reportType, string queryDate)
        {
            if (pager.TotalCount > 0)
            {
                DataTable dtList = reportBLL.GetPageData(isAlarmReport, reportType, queryDate, pager.PageIndex, pageSize);
                dgvDataList.AutoGenerateColumns = true; // DAL 中已写好中文别名，这里直接自动生成
                dgvDataList.DataSource = dtList;
            }
            else
            {
                dgvDataList.DataSource = null;
            }
        }
       

        // ============ 分页控件事件 ============
        private void Pager_PageChanged(object sender, EventArgs e)
        {
            // 当点击 首页/上页/下页/末页/跳转 时触发
            // 此时 pager.PageIndex 已经由 UPager 内部更新完毕，直接去查新页的数据即可
            bool isAlarmReport = rbtnAlarm.Checked;
            string reportType = cboReportTypes.Text;
            string queryDate = dtTime.Value.ToString("yyyy-MM-dd");

            LoadGridData(isAlarmReport, reportType, queryDate);
        }

        // ============ 单选框切换事件 ============
        private void rbtnAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAlarm.Checked)
            {
                // 切换类别时，重置分页并重新加载
                pager.PageIndex = 1;
                LoadAllData();
            }
        }

        private void rbtnData_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnData.Checked)
            {
                pager.PageIndex = 1;
                LoadAllData();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvDataList.Rows.Count == 0)
            {
                MessageBox.Show("没有可导出的数据！", "提示");
                return;
            }

            // 1. 从配置读取路径
            string exportDir = ConfigurationManager.AppSettings["exportPath"];
            if (string.IsNullOrWhiteSpace(exportDir)) exportDir = @"C:\";

            // 2. 弹出保存对话框
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel 文件 (*.xlsx)|*.xlsx";
                sfd.InitialDirectory = exportDir;
                sfd.FileName = $"导出数据_{DateTime.Now:yyyyMMddHHmmss}.xlsx";

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    // 【核心1】暂停 DataGridView 的界面刷新
                    dgvDataList.SuspendLayout();

                    // 把鼠标变成沙漏，提示用户正在处理
                    Cursor.Current = Cursors.WaitCursor;

                    // ========================================================
                    // 【重点修改部分】重新从后台获取全量数据
                    // ========================================================
                    bool isAlarmReport = rbtnAlarm.Checked;
                    string reportType = cboReportTypes.Text;
                    string queryDate = dtTime.Value.ToString("yyyy-MM-dd");

                    // 技巧：把 pageSize 传成一个巨大的数字（比如 100万），这样分页查询就会返回所有匹配的数据
                    int exportPageSize = 1000000;
                    int exportPageIndex = 1;

                    // 调用你的 BLL 获取全量数据
                    DataTable exportData = reportBLL.GetPageData(isAlarmReport, reportType, queryDate, exportPageIndex, exportPageSize);

                    if (exportData == null || exportData.Rows.Count == 0)
                    {
                        MessageBox.Show("没有获取到可导出的数据！", "提示");
                        return;
                    }

                    // ========================================================
                    // 开始生成 Excel（直接遍历 DataTable，速度极快）
                    // ========================================================
                    using (var workbook = new XLWorkbook())
                    {
                        var ws = workbook.Worksheets.Add("数据");

                        // 1. 写表头 (因为 AutoGenerateColumns = true，表头就是 DataTable 的中文别名)
                        for (int c = 0; c < exportData.Columns.Count; c++)
                        {
                            ws.Cell(1, c + 1).Value = exportData.Columns[c].ColumnName;
                            ws.Cell(1, c + 1).Style.Font.Bold = true;
                        }

                        // 2. 写数据
                        int row = 2;
                        foreach (DataRow dr in exportData.Rows)
                        {
                            for (int c = 0; c < exportData.Columns.Count; c++)
                            {
                                ws.Cell(row, c + 1).Value = dr[c]?.ToString() ?? "";
                            }
                            row++;
                        }

                        // 自动列宽并保存
                        ws.Columns().AdjustToContents();
                        workbook.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show($"导出成功！共导出 {exportData.Rows.Count} 条数据。", "提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出失败：{ex.Message}", "错误");
                }
                finally
                {
                    // 【核心2】恢复界面刷新
                    dgvDataList.ResumeLayout();
                    Cursor.Current = Cursors.Default; // 鼠标恢复
                }
            }
        }

        private void UpdateUI(AlarmStatisticsData data)
        {
            // 因为可能在非UI线程触发，这里需要判断是否跨线程
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<AlarmStatisticsData>(UpdateUI), data);
                return;
            }

            // ========== 异常记录统计刷新 ==========
            // 假设你用来显示数字的控件是 Label 或者自定义控件，你需要自己写一个转换方法
            numAlarmCount.Value = Convert.ToDecimal(data.TotalCount);
            numAlarmCount_H.Value = Convert.ToDecimal(data.HighAlarmCount);
            numAlarmCount_L.Value = Convert.ToDecimal(data.LowAlarmCount);
            numAlarmCount_Un.Value = Convert.ToDecimal(data.CancelAlarmCount);
        }

    }
}