using IntelligentDeviceMonitorAndWarningCenter;
using IntelligentEquipmentMonitorAndWarningCenter.UControls;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IntelligentEquipmentMonitorAndWarningCenter
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            // 把初始化的加载事件进行绑定
            this.Load += FrmMain_Load;
        }

        //对导航栏的初始化
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化通信状态
            lblConnectState.Text = "未连接";
            lblConnectState.ForeColor = System.Drawing.Color.Red;
            if (this.Tag != null)
            {
                lblLoginUser.Text = this.Tag.ToString();
            }
            //初始化导航栏
            foreach (Control c in tableNavBar.Controls)
            {
                if (c is UNavItem item)
                {
                    item.Navigate += Item_Navigate;

                }
            }
            //加载文件路径信息
            LoadPaths();

            //初始化刷新通信状态的委托
            CommonHelper.reloadCommunicationState += UpdateCommunicationState;
            //获取系统配置的启动状态
            string enableSetting = AppHelper.GetValue("enableSetting");
            if (string.IsNullOrEmpty(enableSetting))
            {
                MessageHelper.Warning("系统提示", "当期未启用系统配置，不能进行设备监控");
                MessageBox.Show("系统提示，当期未启用系统配置，不能进行设备监控");

            }
            else
            {
                //把当前配置的状态给读取出出来
                CommonHelper.isEnableSetting = Convert.ToBoolean(enableSetting);

            }
            //默认打开设备监控页面
            Utility.ShowChildPage<FrmDeviceMonitor>(panelPage);
            //选择监控页
            navDeviceMonitor.SelectNavItem();

        }

        // 读取加载文件路径信息
        private void LoadPaths()
        {
            //删除老的数据库信息
            string oldDbFile = AppHelper.GetValue("OldDbFile");
            if (!string.IsNullOrEmpty(oldDbFile))
            {
               if(File.Exists(oldDbFile)) { File.Delete(oldDbFile); AppHelper.SetValue("oldDbFile", ""); }
            }

            string storePathFile = AppHelper.GetValue("storePathFile");
            if (!string.IsNullOrEmpty(storePathFile))
            {
                CommonHelper.storePathFile = storePathFile;
            }
            else
            {
                storePathFile = ConfigurationManager.AppSettings[storePathFile].ToString();
            }
            //如果这两种方法(从配置，从程序)都不行，代表我们没有配置
            if (string.IsNullOrEmpty(storePathFile))
            {
                MessageHelper.Warning("加载提示", "请先进行系统存储配置，否则无法正常使用系统");
                //MessageBox.Show("加载提示：请先进行系统存储配置，否则无法正常使用系统");
                return;
            }
            //读所有路径信息
            List<string> lines = TextHelper.ReadTextAllLines(storePathFile);
            if (lines.Count > 0)
            {
                string storePath = lines[0].Split("：")[1].Trim();
                if (storePath.Length > 0)
                {
                    CommonHelper.storePath = storePath;
                }
                //数据库文件名
                string dataFileName = lines[1].Split('：')[1].Trim();
                if (!string.IsNullOrEmpty(dataFileName))
                {
                    //文件的完整路径
                    CommonHelper.dbFile = Path.Combine(storePath, dataFileName);
                }

                //通信配置文件名
                string comFileName = lines[2].Split('：')[1].Trim();
                if (!string.IsNullOrEmpty(comFileName))
                {
                    //文件的完整路径
                    CommonHelper.communicationFile = Path.Combine(storePath, comFileName);
                }

                //预警配置文件名
                string alarmFileName = lines[3].Split('：')[1].Trim();
                if (!string.IsNullOrEmpty(alarmFileName))
                {
                    //文件的完整路径
                    CommonHelper.alarmSetsFile = Path.Combine(storePath, alarmFileName);
                }
            }
        }
        //刷新通信状态
        private void UpdateCommunicationState()
        {
            if (CommonHelper.communicationState == true)
            {
                lblConnectState.Text = "已连接";
                lblConnectState.ForeColor = Color.DeepSkyBlue;
            }
            else
            {
                lblConnectState.Text = "未连接";
                lblConnectState.ForeColor = Color.Red;
            }
        }

        //导航项统一导航功能
        private void Item_Navigate(object? sender, EventArgs e)
        {
            UNavItem item = (UNavItem)sender;
            string tagStr = item.Tag?.ToString();
            if (tagStr != null)
            {
                switch (tagStr)
                {
                    case "systemconfig":
                        Utility.ShowChildPage<FrmSysSetting>(panelPage);
                        break;
                    case "devicemonitor":
                        Utility.ShowChildPage<FrmDeviceMonitor>(panelPage);
                        break;
                    case "alarmmanger":
                        Utility.ShowChildPage<FrmAlarmManage>(panelPage);
                        break;
                    case "livetrends":
                        Utility.ShowChildPage<FrmTrends>(panelPage);
                        break;
                    case "reports":
                        Utility.ShowChildPage<FrmReportManage>(panelPage);
                        break;

                }
            }
        }

        private void navReportManger_Load(object sender, EventArgs e)
        {

        }

        //子页尺寸应该自适应面板尺寸
        private void panelPage_SizeChanged(object sender, EventArgs e)
        {
            Utility.panelPage_SizeChanged(sender);
        }

        //系统退出
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Confirm("退出提示", "你确定要退出系统吗") == DialogResult.OK)
            {
                //关闭窗口时候取消订阅
                CommonHelper.reloadCommunicationState -= UpdateCommunicationState;
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }

        }

        //解决切换页面明显闪烁的感觉
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

    }


}
