using IntelligentDeviceMonitorAndWarningCenter.SysConfigs;
using IntelligentEquipmentMonitorAndWarningCenter.SysConfigs;
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

namespace IntelligentEquipmentMonitorAndWarningCenter
{
    public partial class FrmSysSetting : Form
    {
        public FrmSysSetting()
        {
            InitializeComponent();
            btnStore.Click += BtnStore_Click;
            btnCommunicate.Click += BtnCommunicate_Click;
            btnPara.Click += BtnPara_Click;
            btnAlarm.Click += BtnAlarm_Click;
        }

        private void BtnAlarm_Click(object sender, EventArgs e)
        {
            Utility.ShowChildPage<FrmAlarmConfig>(panelChild);
        }

        private void BtnPara_Click(object sender, EventArgs e)
        {
            Utility.ShowChildPage<FrmParaConfig>(panelChild);
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            Utility.ShowChildPage<FrmStoreConfig>(panelChild);
        }
        private void BtnCommunicate_Click(object sender, EventArgs e)
        {
            Utility.ShowChildPage<FrmCommunicateConfig>(panelChild);
        }

        private void FrmSysSetting_Load(object sender, EventArgs e)
        {
            //初始化启用状态
            chkEnableSetting.Checked = CommonHelper.isEnableSetting;
            if (chkEnableSetting.Checked) {
                chkEnableSetting.ForeColor = Color.Orange;
            }
            else
            {
                chkEnableSetting.ForeColor = Color.White;
            }
           //默认显示存储配置页
            Utility.ShowChildPage<FrmStoreConfig>(panelChild);
            btnStore.Focus();
        }

        //子页自适应面板大小
        private void panelChild_SizeChanged(object sender, EventArgs e)
        {
            Utility.panelPage_SizeChanged(panelChild);
        }

        //启用或者取消系统配置
        private void chkEnableSetting_Click(object sender, EventArgs e)
        {
            if (chkEnableSetting.Checked)
            {
                chkEnableSetting.ForeColor = Color.Orange;
                AppHelper.SetValue("enableSetting", "true");
                CommonHelper.isEnableSetting = true;
            }
            //取消配置
            else
            {
                //通信连接状态的时候不允许取消
                if (CommonHelper.communicationState)
                {
                    MessageHelper.Warning("取消警告", "当前系统已经连接 不能取消应用");
                    chkEnableSetting.Checked = true;
                    return;
                }
                else
                {
                    chkEnableSetting.ForeColor = Color.Gainsboro;
                    AppHelper.SetValue("enableSetting", "false");
                    CommonHelper.isEnableSetting = false;
                }
            }
            //不管是否成功，都进刷新
            CommonHelper.reloadSettingState?.Invoke();// 刷新设置状态
        }

    }
}
