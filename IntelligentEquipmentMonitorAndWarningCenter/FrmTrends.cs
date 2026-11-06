using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEMAWC.BLL;
using IEMAWC.DAL;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;

namespace IntelligentDeviceMonitorAndWarningCenter
{
    public partial class FrmTrends : Form
    {
        public FrmTrends()
        {
            InitializeComponent();
            var legend = chart1.Legends[0];
            legend.Position.Auto = true;
            chart1.Series[0].Name = "温度";
            chart1.Series[1].Name = "湿度";
            chart1.Series[2].Name = "亮度";
            this.Load += FrmTrends_Load;
        }

        private readonly DataInfoBLL dataInfoBLL = new DataInfoBLL();
        private System.Windows.Forms.Timer realTimer;//实时曲线刷新定时器
        private bool autoUpdate = true;//实时曲线是否自动刷新

        private void FrmTrends_Load(object sender, EventArgs e)
        {
            //数据点数范围
            valCount.Minimum = 1;
            valCount.Maximum = 500;
            //默认查询时间范围：最近1小时
            dtStartTime.Value = DateTime.Now.AddHours(-1);
            dtEndTime.Value = DateTime.Now;
            //默认显示全部曲线
            chk_T.Checked = chk_H.Checked = chk_B.Checked = true;
            //默认实时曲线
            rbtnRealTrends.Checked = true;

            //订阅事件
            rbtnRealTrends.CheckedChanged += TrendType_CheckedChanged;
            rbtnHistoryTrends.CheckedChanged += TrendType_CheckedChanged;
            chk_T.CheckedChanged += Series_CheckedChanged;
            chk_H.CheckedChanged += Series_CheckedChanged;
            chk_B.CheckedChanged += Series_CheckedChanged;
            btnUpdate.Click += BtnUpdate_Click;
            btnHistoryFind.Click += BtnHistoryFind_Click;

            SwitchTrendType();

            //实时刷新定时器，仅在本页可见时工作
            realTimer = new System.Windows.Forms.Timer { Interval = 2000 };
            realTimer.Tick += RealTimer_Tick;
            this.VisibleChanged += (s, ev) => { if (this.Visible) realTimer.Start(); else realTimer.Stop(); };
            this.FormClosed += (s, ev) => realTimer.Stop();
            realTimer.Start();
        }


        #region 曲线加载

        /// <summary>
        /// 切换实时/历史曲线，并同步各查询条件控件的可用状态
        /// </summary>
        private void SwitchTrendType()
        {
            bool isReal = rbtnRealTrends.Checked;
            valCount.Enabled = isReal;
            btnUpdate.Enabled = isReal;
            dtStartTime.Enabled = dtEndTime.Enabled = btnHistoryFind.Enabled = !isReal;
            RefreshTrends();
        }

        /// <summary>
        /// 按当前曲线类型重新加载曲线数据
        /// </summary>
        private void RefreshTrends()
        {
            if (rbtnRealTrends.Checked)
            {
                lblTitle.Text = "实时曲线图";
                BindSeries(dataInfoBLL.GetLatestDataInfos((int)valCount.Value));
            }
            else
            {
                lblTitle.Text = "历史曲线图";
                LoadHistoryTrends();
            }
        }

        /// <summary>
        /// 历史曲线查询：按时间范围查询，时间范围不能超过10小时
        /// </summary>
        private void LoadHistoryTrends()
        {
            DateTime start = dtStartTime.Value;
            DateTime end = dtEndTime.Value;
            if (end <= start)
            {
                MessageHelper.Warning("查询提示", "查询的开始时间必须小于结束时间！");
                return;
            }
            if ((end - start).TotalHours > 10)
            {
                MessageHelper.Warning("查询提示", "不能超过10小时的时间范围！");
                return;
            }
            BindSeries(dataInfoBLL.GetDataInfos(start, end));
        }

        /// <summary>
        /// 将采集数据绑定到曲线的三个序列上
        /// Series1-温度 Series2-湿度 Series3-亮度
        /// </summary>
        private void BindSeries(List<DataInfo> list)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            foreach (DataInfo data in list)
            {
                if (!DateTime.TryParse(data.CollectionTime, out DateTime time)) continue;
                if (chk_T.Checked) chart1.Series[0].Points.AddXY(time, data.Temperature);
                if (chk_H.Checked) chart1.Series[1].Points.AddXY(time, data.Humidity);
                if (chk_B.Checked) chart1.Series[2].Points.AddXY(time, data.Brightness);
            }
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        #endregion

        #region 事件处理

        private void TrendType_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton rbtn && rbtn.Checked)
            {
                SwitchTrendType();
            }
        }

        private void Series_CheckedChanged(object? sender, EventArgs e)
        {
            RefreshTrends();
        }

        /// <summary>
        /// 开始/停止实时更新
        /// </summary>
        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            autoUpdate = !autoUpdate;
            btnUpdate.Text = autoUpdate ? "停止更新" : "开始更新";
            if (autoUpdate)
            {
                RefreshTrends();
            }
        }

        /// <summary>
        /// 历史查询
        /// </summary>
        private void BtnHistoryFind_Click(object? sender, EventArgs e)
        {
            LoadHistoryTrends();
        }

        private void RealTimer_Tick(object? sender, EventArgs e)
        {
            if (autoUpdate && rbtnRealTrends.Checked)
            {
                RefreshTrends();
            }
        }

        #endregion

    }
}
