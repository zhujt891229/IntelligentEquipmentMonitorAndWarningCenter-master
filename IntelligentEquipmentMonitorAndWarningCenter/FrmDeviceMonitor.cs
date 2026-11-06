using IEMAWC.DAL;
using IntelligentDeviceMonitorAndWarningCenter.SysConfigs;
using IntelligentEquipmentMonitorAndWarningCenter;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentDeviceMonitorAndWarningCenter
{
    public partial class FrmDeviceMonitor : Form
    {
        // 生成模拟数据的操作
        private readonly DataSimulationService _simService = new DataSimulationService();
        ModbusRtuHelper modbusRtuHelper = new ModbusRtuHelper();
        private AlarmDataManager _dataManager;

        #region 自定义 历史最大最小值，用作从当前开始的刷新
        private static double History_Max_Temp = -100;
        private static double History_Min_Temp = 200;

        private static double History_Max_Hum = -100;
        private static double History_Min_Hum = 200;

        private static double History_Max_Bri = -100;
        private static double History_Min_Bri = 200;
        #endregion  

        DataInfoDAL dataInfoDAL = new DataInfoDAL();
        public FrmDeviceMonitor()
        {
            InitializeComponent();
            // 订阅模拟服务的事件   初始化的时候进行委托的绑定
            _simService.OnDataGenerated += SimService_OnDataGenerated;
            _simService.OnAlarmGenerated += SimService_OnAlarmGenerated;
            //实时更新列表数据
            _simService.OnUpdateDataed += SimService_OnUpdateDataed;
            CommonHelper.reloadCommunicationState += ReloadCommunicationState;
            _dataManager = new AlarmDataManager();
            _dataManager.OnDataUpdated += UpdateUI;

        }
        private void FrmDeviceMonitor_Load(object sender, EventArgs e)
        {
            //先关闭数据的生成 窗体加载时，启动数据模拟任务
            _simService.StartSimulation();
            cboPorts.DataSource = modbusRtuHelper.GetPortNames();
            cboPorts.SelectedIndex = 0;

            _dataManager.RefreshData();
        }

        private void ReloadCommunicationState()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ReloadCommunicationState));
                return;
            }

            // 按全局状态更新本界面的按钮文字和指示灯
            if (CommonHelper.communicationState)
            {
                btnConnect.Text = "断开连接";
            }
            else
            {
                btnConnect.Text = "连接设备";
            }
        }

        // 连接plc 设备 实现数据采集
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CommonHelper.communicationState)
                {
                    // === 连接 ===
                    bool IsConnected = modbusRtuHelper.Connect(cboPorts.Text);
                    CommonHelper.communicationState = IsConnected;
                    CommonHelper.NotifyCommunicationStateChanged();
                    MessageBox.Show(IsConnected ? "连接成功" : "连接失败");
                }
                else
                {
                    // === 断开 ===
                    modbusRtuHelper.Close();
                    CommonHelper.communicationState = false;
                    CommonHelper.NotifyCommunicationStateChanged();
                }
            }
            catch (Exception ex)
            {
                CommonHelper.communicationState = false;
                CommonHelper.NotifyCommunicationStateChanged();
                MessageBox.Show("操作异常：" + ex.Message);
            }
        }

        //刷新按钮，刷新串口
        private void btnRefreshPorts_Click(object sender, EventArgs e)
        {
            cboPorts.DataSource = modbusRtuHelper.GetPortNames();
            cboPorts.SelectedIndex = 0;
        }

        // 窗体关闭时，停止任务，释放资源  Invoke 调用已释放窗体
        private void FrmDeviceMonitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //取消订阅，停止采集
            CommonHelper.reloadCommunicationState -= ReloadCommunicationState;
            _simService.StopSimulation();
        }

        /// <summary>
        /// 处理生成的新数据
        /// </summary>
        private void SimService_OnDataGenerated(DataInfo data)
        {
            if (this.IsDisposed)
                return;

            // 1. 写入正常数据到数据库 (调用你之后实现的方法)
            _simService.InsertDataToDatabase(data);

            // 刷新历史最大值
            if (data.Temperature > History_Max_Temp) History_Max_Temp = data.Temperature;
            if (data.Temperature < History_Min_Temp) History_Min_Temp = data.Temperature;
            if (data.Humidity > History_Max_Hum) History_Max_Hum = data.Humidity;
            if (data.Humidity < History_Min_Hum) History_Min_Hum = data.Humidity;
            if (data.Brightness > History_Max_Bri) History_Max_Bri = data.Brightness;
            if (data.Brightness < History_Min_Bri) History_Min_Bri = data.Brightness;


            // 2. 跨线程更新UI (如果需要显示在界面上)
            this.Invoke(new Action(() =>
            {
                // 假设你界面上有名为 lblHTemp, lblHum, lblBright, lblTime 的Label
                lblValue_T.Text = data.Temperature.ToString();
                lblValue_H.Text = data.Humidity.ToString();
                lblValue_B.Text = data.Brightness.ToString();
                //更新控件值
                meter_T.Value = data.Temperature;
                meter_H.Value = data.Humidity;
                meter_B.Value = data.Brightness;
                lblHistoryH_T.Text = History_Max_Temp.ToString() + "℃";
                lblHistoryL_T.Text = History_Min_Temp.ToString() + "℃";
                lblHistoryH_H.Text = History_Max_Hum.ToString() + " %";
                lblHistoryL_H.Text = History_Min_Hum.ToString() + " %";
                lblHistoryH_B.Text = History_Max_Bri.ToString() + "cd/m2";
                lblHistoryL_B.Text = History_Min_Bri.ToString() + "cd/m2";
            }));
        }

        /// <summary>
        /// 处理生成的报警数据 后续放到报警页面 
        /// 生产了报警数据给加入进去并且刷新报警页面数据
        /// </summary>
        private void SimService_OnAlarmGenerated(AlarmLog alarm)
        {
            if (this.IsDisposed)
                return;

            // 1. 写入报警数据到数据库 (调用你之后实现的方法)
            _simService.InsertAlarmToDatabase(alarm);

            // 2. 跨线程更新UI/弹窗提示 (可选)
            // this.Invoke(new Action(() =>
            //{
            // 例如在日志列表中添加一条记录
            // listBoxLogs.Items.Add($"[{alarm.AlarmTime}] {alarm.AlarmNote}");
            //}));
        }

        public void SimService_OnUpdateDataed(BindingList<DataInfo> list)
        {

            //直接赋值不对
            //dgvDataList.AutoGenerateColumns = false;   // 关键：禁用自动生成列
            //dgvDataList.DataSource = list;

            if (this.IsDisposed)
                return;

            //应该从后台进程切换回ui 线程，然后进行数据的赋值
            if (dgvDataList.InvokeRequired)
            {
                dgvDataList.Invoke(new Action(() => SimService_OnUpdateDataed(list)));
                return;
            }

            dgvDataList.AutoGenerateColumns = false;
            dgvDataList.DataSource = null;   // 先清空，避免刷新问题
            dgvDataList.DataSource = list;
        }

        private void UpdateUI(AlarmStatisticsData data)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<AlarmStatisticsData>(UpdateUI), data);
                return;
            }

            // 只需要刷新设备预警相关的数据
            numAllAlarms.Value = Convert.ToDecimal(data.DeviceWarningTotal);  // 截图显示4位
            numAlarms_T.Value = Convert.ToDecimal(data.TempWarningCount);
            numAlarms_H.Value = Convert.ToDecimal(data.HumWarningCount);
            numAlarms_B.Value = Convert.ToDecimal(data.LightWarningCount);
          
        }

        private bool isSyncingUI = false;

        // ================= 全控开关逻辑 =================
        private void switchAll_CheckedChanged(object sender, EventArgs e)
        {
            // 1. 如果正在代码同步UI，直接退出，防止死循环
            if (isSyncingUI) return;

            // 2. 检查是否连接
            if (!CommonHelper.communicationState)
            {
                MessageBox.Show("请先连接设备！");
                // 回退状态
                isSyncingUI = true;
                switchAll.Checked = !switchAll.Checked;
                isSyncingUI = false;
                return;
            }

            try
            {
                bool targetState = switchAll.Checked;
                // 写入线圈 0（全控一般是一个地址，或者你循环写0-4）
                // 如果全控在PLC里是一个独立地址（比如地址 10），请改成 WriteCoil(10, targetState)
                for (ushort i = 0; i <= 4; i++)
                {
                    modbusRtuHelper.WriteCoil(i, targetState);
                }

                // 更新UI上 5 个灯珠的状态（不触发单灯的 changed 事件）
                // 同步 5 个灯珠的 UI
                isSyncingUI = true;
                jswLight01.IsOn = targetState;
                jswLight02.IsOn = targetState;
                jswLight03.IsOn = targetState;
                jswLight04.IsOn = targetState;
                jswLight05.IsOn = targetState;
                isSyncingUI = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("全控操作失败：" + ex.Message);
            }
        }

     
    }
}
