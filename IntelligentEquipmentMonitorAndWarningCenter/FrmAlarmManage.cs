using IEMAWC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentDeviceMonitorAndWarningCenter
{
    public partial class FrmAlarmManage : Form
    {
        AlarmInfoBLL alarmInfoBLL = new AlarmInfoBLL();

        // 分页参数（只保留 pageSize，其它由 pager 控件管理）
        private int pageSize = 20;

        public FrmAlarmManage()
        {
            InitializeComponent();
            // 绑定事件，解决点击复选框不生效的问题
            dgvAlarmLogList.CurrentCellDirtyStateChanged += DgvAlarmLogList_CurrentCellDirtyStateChanged;
            dgvAlarmLogList.CellMouseClick += DgvAlarmLogList_CellMouseClick;

            // 【关键】绑定分页控件的统一事件（替代原来的 First/Prev/Next/Last 四个事件）
            pager.PageChanged += pager_PageChanged;
            pager.PageSize = pageSize;
        }

        private void FrmAlarmManage_Load(object sender, EventArgs e)
        {
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            cboInfoTypes.Items.Clear();
            cboInfoTypes.Items.Add("全部");
            cboInfoTypes.Items.Add("温度");
            cboInfoTypes.Items.Add("湿度");
            cboInfoTypes.Items.Add("亮度");
            cboInfoTypes.SelectedIndex = 0;

            // 加载报警信息
            BindData();
        }

        private void DgvAlarmLogList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvAlarmLogList.IsCurrentCellDirty)
            {
                dgvAlarmLogList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvAlarmLogList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                dgvAlarmLogList.EndEdit();

                DataGridViewCheckBoxCell cell = dgvAlarmLogList.Rows[e.RowIndex].Cells[0] as DataGridViewCheckBoxCell;
                if (cell != null)
                {
                    bool currentValue = Convert.ToBoolean(cell.Value);
                    cell.Value = !currentValue;
                }
            }
        }

        // 查询按钮
        private void btnFind_Click(object sender, EventArgs e)
        {
            pager.PageIndex = 1;   // 查询时重置为第一页
            BindData();
        }

        private void BindData()
        {
            try
            {
                // 1. 报警类别
                int alarmType = rbtnRealTimeAlarm.Checked ? 0 : 1;

                // 2. 报警状态
                var states = new List<string>();
                if (checkBox1.Checked) states.Add("1");
                if (checkBox2.Checked) states.Add("0");
                if (checkBox3.Checked) states.Add("2");
                if (checkBox4.Checked) states.Add("3");

                // 3. 报警来源
                int infoType = -1;
                switch (cboInfoTypes.Text)
                {
                    case "温度": infoType = 0; break;
                    case "湿度": infoType = 1; break;
                    case "亮度": infoType = 2; break;
                    default: infoType = -1; break;
                }

                // 4. 时间范围
                string startStr = dtStartTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string endStr = dtEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss");

                // 5. 先查总记录数，并交给 pager 控件（控件内部会计算总页数、按钮状态、文字）
                int totalCount = alarmInfoBLL.GetTotalCount(alarmType, states, infoType, startStr, endStr);
                pager.PageSize = pageSize;
                pager.TotalCount = totalCount;

                // 6. 校正 PageIndex（防止当前页超出范围）
                if (pager.PageIndex > pager.PageNum && pager.PageNum > 0)
                    pager.PageIndex = pager.PageNum;
                if (pager.PageIndex < 1)
                    pager.PageIndex = 1;

                // 7. 分页查询
                DataTable dt = alarmInfoBLL.GetAlarmList(
                    alarmType, states, infoType, startStr, endStr,
                    pager.PageIndex, pageSize);

                // 8. 绑定数据
                dgvAlarmLogList.AutoGenerateColumns = false;
                dgvAlarmLogList.DataSource = dt;
                dgvAlarmLogList.ClearSelection();

                foreach (DataGridViewRow row in dgvAlarmLogList.Rows)
                {
                    if (row.Cells[0] is DataGridViewCheckBoxCell)
                    {
                        row.Cells[0].Style.BackColor = Color.FromArgb(40, 80, 120);
                        row.Cells[0].Style.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询数据失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 删除按钮
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvAlarmLogList.EndEdit();

            List<long> selectedIds = new List<long>();

            foreach (DataGridViewRow row in dgvAlarmLogList.Rows)
            {
                if (row.IsNewRow) continue;

                bool isChecked = false;
                if (row.Cells[0].Value != null && row.Cells[0].Value != DBNull.Value)
                {
                    isChecked = Convert.ToBoolean(row.Cells[0].Value);
                }

                if (isChecked)
                {
                    if (row.DataBoundItem is DataRowView drv)
                    {
                        if (drv.Row.Table.Columns.Contains("LogId"))
                        {
                            long id = Convert.ToInt64(drv["LogId"]);
                            selectedIds.Add(id);
                        }
                    }
                }
            }

            if (selectedIds.Count == 0)
            {
                MessageBox.Show("请选择要删除的参数信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"确定要删除选中的 {selectedIds.Count} 条记录吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (alarmInfoBLL.DeleteAlarmLogs(selectedIds))
                {
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindData(); // 刷新表格
                }
                else
                {
                    MessageBox.Show("删除失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ============ 分页事件（统一用一个 PageChanged） ============
        private void pager_PageChanged(object sender, EventArgs e)
        {
            // pager 控件内部已经修改了 PageIndex 并刷新了按钮状态和文字
            // 这里只需要重新查询数据即可
            BindData();
        }
    }
}