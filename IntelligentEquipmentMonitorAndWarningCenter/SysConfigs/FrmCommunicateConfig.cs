using Common;
using IntelligentEquipmentMonitorAndWarningCenter.Models;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentEquipmentMonitorAndWarningCenter.SysConfigs
{
    /// <summary>
    /// 通信配置窗体，用于配置串口通信参数（波特率、校验位、数据位、停止位）
    /// </summary>
    public partial class FrmCommunicateConfig : Form
    {
        public FrmCommunicateConfig()
        {
            InitializeComponent();
        }

        //检查通信文件是否存在，存在的话读取配置，加载初始化下拉框
        // 通信配置文件的路径，从公共帮助类中获取
        string comPath = CommonHelper.communicationFile;

        /// <summary>
        /// 窗体加载事件：检查文件、加载下拉框、加载通信配置、初始化状态
        /// </summary>
        private void FrmCommunicateConfig_Load(object sender, EventArgs e)
        {
            //检查文件路径是否为空
            if (string.IsNullOrEmpty(comPath))
            {
                // 未配置存储路径时给出警告，并隐藏提交按钮
                MessageHelper.Warning("加载提示", "当前未进行存储路径配置，无法进行通信配置");
                btnOK.Visible = false; //隐藏提交按钮
                return;
            }
            //加载下拉框：波特率、校验位
            LoadBaudRates();
            LoadParities();
            lblMsg.Visible = false; //先隐藏消息栏
            //通信配置加载
            LoadCommunicateSets();

            //初始化同步刷新委托，用于其他页面修改配置后同步刷新本页面状态
            CommonHelper.reloadSettingState = CheckSettingState;
            //同步启动状态检查
            CheckSettingState();
        }

        /// <summary>
        /// 检查设置状态：根据系统是否已配置，决定控件是否可编辑
        /// </summary>
        private void CheckSettingState()
        {
            if (CommonHelper.isEnableSetting)
            {
                // 系统已经配置，禁止修改，显示错误提示，禁用相关控件
                lblMsg.SetErrmsg("系统已经配置，不能再修改");
                cboBaudRate.Enabled = false;
                cboParity.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                btnOK.Visible = false;
            }
            else
            {
                // 系统未配置，允许修改，隐藏提示，启用相关控件
                lblMsg.Hide();
                cboBaudRate.Enabled = true;
                cboParity.Enabled = true;
                panel1.Enabled = true;
                panel2.Enabled = true;
                btnOK.Visible = true;
            }
        }

        /// <summary>
        /// 加载波特率选项到下拉框
        /// </summary>
        private void LoadBaudRates()
        {
            // 常用波特率数组
            int[] baudrates = { 4800, 9600, 14000, 19200, 38400, 57600 };
            cboBaudRate.Items.Clear();
            foreach (int b in baudrates)
            {
                cboBaudRate.Items.Add(b);
            }
        }

        /// <summary>
        /// 加载校验位选项到下拉框
        /// </summary>
        private void LoadParities()
        {
            cboParity.Items.Clear();
            // 校验位选项：无、奇、偶、标记、空格
            string[] parities = { "None", "Odd", "Even", "Mark", "Space" };

            cboParity.Items.Clear();
            foreach (string p in parities)
            {
                cboParity.Items.Add(p);
            }
        }

        /// <summary>
        /// 加载通信配置：从文件或默认值加载，并回显到界面控件
        /// </summary>
        private void LoadCommunicateSets()
        {
            if (CommonHelper.communicateSet == null)
            {
                // 通信配置对象为空，尝试从文件加载
                FileConvert.LoadCommunicateSets();
            }
            if (CommonHelper.communicateSet != null)
            {
                // 加载通信配置到界面控件
                CommunicateSet comSet = CommonHelper.communicateSet;
                cboBaudRate.SelectedItem = comSet.BaudRate;           // 波特率
                cboParity.SelectedItem = comSet.Parity.ToString();    // 校验位
                // 数据位：7 或 8
                if (comSet.DataBits == 7)
                {
                    rbtnBits_7.Checked = true;
                }
                else
                {
                    rbtnBits_8.Checked = true;
                }
                // 停止位：1 或 2
                if (comSet.StopBits == StopBits.One)
                {
                    rbtnStopBits_1.Checked = true;
                }
                else
                {
                    rbtnStopBits_2.Checked = true;
                }
            }
            else
            {
                // 无配置文件时，使用默认初始化配置
                cboBaudRate.SelectedItem = 4800;
                cboParity.SelectedItem = "Even";
                rbtnBits_8.Checked = true;
                rbtnStopBits_1.Checked = true;
            }
        }

        /// <summary>
        /// 窗体可见性变化事件：当窗体再次可见时，同步刷新状态
        /// 解决了两个页面保存时第二个页面无法保存的问题
        /// </summary>
        private void FrmCommunicateConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)  //解决了两个页面保存，第二个页面无法保存问题
            {
                //同步刷新委托
                CommonHelper.reloadCommunicationState = CheckSettingState;
                //同步启用状态
                CheckSettingState();
            }
        }

        /// <summary>
        /// 通信连接设置提交按钮点击事件：收集界面数据，写入文件，并更新内存中的配置对象
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //接收界面信息
            string baudRate = cboBaudRate.Text.Trim();                              // 波特率
            string parity = cboParity.Text.Trim();                                  // 校验位
            string dataBits = rbtnBits_7.Checked ? "7" : "8";                       // 数据位
            string stopBits = rbtnStopBits_1.Checked ? rbtnStopBits_1.Text : rbtnStopBits_2.Text; // 停止位

            //存储处理：将配置项存入字典
            Dictionary<string, string> dicSets = new Dictionary<string, string>();
            dicSets.Add("BaudRate", baudRate);
            dicSets.Add("Parity", parity);
            dicSets.Add("DataBits", dataBits);
            dicSets.Add("StopBits", stopBits);

            //写入文件：根据文件扩展名选择写入格式
            string ext = Path.GetExtension(comPath); //获取扩展名
            if (ext == ".txt")
            {
                // 按照 txt 格式写入
                FileConvert.WriteCommunicateSetToTxt(comPath, dicSets);
            }
            else if (ext == ".xml")
            {
                // 按照 xml 格式写入
                FileConvert.WriteCommunicateSetToXML(comPath, dicSets);
            }
            else
            {
                // 不支持的文件格式，提示错误并返回
                lblMsg.SetErrmsg("通信配置文件格式不对");
                return;
            }
            // 提示保存成功
            lblMsg.SetSuccmsg("通信连接配置保存成功");

            //更新到通信连接设置对象中
            CommunicateSet comSet = new CommunicateSet()
            {
                BaudRate = baudRate.GetInt(),                       // 字符串转 int
                Parity = Enum.Parse<Parity>(parity),                // 字符串转枚举
                DataBits = dataBits.GetInt(),                       // 字符串转 int
                StopBits = Enum.Parse<StopBits>(stopBits)           // 字符串转枚举
            };
            CommonHelper.communicateSet = comSet; // 更新全局通信配置对象
        }
    }
}