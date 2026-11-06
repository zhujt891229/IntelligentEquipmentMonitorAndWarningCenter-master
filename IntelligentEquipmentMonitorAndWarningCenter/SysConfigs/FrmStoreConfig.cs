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

namespace IntelligentEquipmentMonitorAndWarningCenter.SysConfigs
{
    public partial class FrmStoreConfig : Form
    {
        bool dbExist = false;//数据库文件是否存在
        bool isFirstShow = true;//第一次显示窗体
        public FrmStoreConfig()
        {
            InitializeComponent();
        }
        private void FrmStoreConfig_Load(object sender, EventArgs e)
        {
            //把默认配置的文件信息给添加进来（初始化存储路径）
            if (!string.IsNullOrEmpty(CommonHelper.storePath))
            {
                txtStorePath.Text = CommonHelper.storePath;
            }
            else
            {
                txtStorePath.Clear();
            }
            //各类文件名和类型的加载
            if (!string.IsNullOrEmpty(CommonHelper.dbFile))
            {
                //获取数据库文件名(包含扩展名称)
                txtDbaseFileName.Text = Path.GetFileName(CommonHelper.dbFile);
                //获取扩展名称
                string ext = Path.GetExtension(CommonHelper.dbFile);
                cboDbTypes.SelectedItem = ext;
                //如果文件名已经存在的话，呢他的后缀名称就不能修改
                if (File.Exists(CommonHelper.dbFile))
                {
                    cboDbTypes.Enabled = false;
                    dbExist = true;
                }
                else
                {
                    cboDbTypes.Enabled = true;
                }
            }
            //配置通信文件名和类型
            if (!string.IsNullOrEmpty(CommonHelper.communicationFile))
            {
                txtCommunicationFileName.Text = Path.GetFileName(CommonHelper.communicationFile);
                cboComFileTypes.SelectedItem = Path.GetExtension(CommonHelper.communicationFile);
            }
            else
            {
                txtCommunicationFileName.Text = "Communication.txt";
                cboComFileTypes.SelectedIndex = 0;

            }

            //预警文件名和类型
            if (!string.IsNullOrEmpty(CommonHelper.alarmSetsFile))
            {
                txtAlarmFileName.Text = Path.GetFileName(CommonHelper.alarmSetsFile);
                cboAlarmFileTypes.SelectedItem = Path.GetExtension(CommonHelper.alarmSetsFile);
            }
            else
            {
                txtCommunicationFileName.Text = "AlarmSets.txt";
                cboAlarmFileTypes.SelectedIndex = 0;

            }
            //刷新
            CommonHelper.reloadSettingState = CheckSettingState;
            //判断是否可以进行配置（如果配置已经确定，不能新配置）
            CheckSettingState();

            //文本框事件订阅
            txtStorePath.TextChanged += TxtBox_TextChanged;
            txtCommunicationFileName.TextChanged += TxtBox_TextChanged;
            txtDbaseFileName.TextChanged += TxtBox_TextChanged;
            txtAlarmFileName.TextChanged += TxtBox_TextChanged;

            //keyup 事件
            txtCommunicationFileName.KeyUp += TxtBox_KeyUp;
            txtDbaseFileName.KeyUp += TxtBox_KeyUp;
            txtAlarmFileName.KeyUp += TxtBox_KeyUp;

        }

        //文本框内容修改
        private void TxtBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = txt.Text;
                string fileType = "";
                if (txt == txtDbaseFileName) fileType = cboDbTypes.Text;
                else if (txt == txtCommunicationFileName) fileType = cboComFileTypes.Text;
                else if (txt == txtAlarmFileName) fileType = cboAlarmFileTypes.Text;
                if (fileName.Contains(".")) txt.Text = fileName.Split('.')[0] + fileType;
                else txt.Text = fileName + fileType;
            }
        }

        //文本框内容修改
        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (!string.IsNullOrEmpty(txt.Text))
            {
                lblMsg.Hide();
            }
        }
        private void CheckSettingState()
        {
            if (CommonHelper.isEnableSetting)
            {
                lblMsg.SetErrmsg("系统配置已经启用，不能再修改");
                btnOK.Visible = false;
                btnChoose.Visible = false;
                if (dbExist == false) cboDbTypes.Enabled = false;
                cboComFileTypes.Enabled = false;
                cboAlarmFileTypes.Enabled = false;
            }
            else
            {
                btnOK.Visible = true;
                btnChoose.Visible = true;
                //如果文件中能读取到，判断优先级比较高
                if (dbExist == false)
                {
                    cboDbTypes.Enabled = true;
                }
                else
                {
                    cboDbTypes.Enabled = false;
                }
                cboComFileTypes.Enabled = true;
                cboAlarmFileTypes.Enabled = true;
                lblMsg.Hide();
            }
        }

        //切换到其他页面的时候 改变初始状态
        private void FrmStoreConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false && isFirstShow == true)
            {
                isFirstShow = false;
            }
            else if (this.Visible && isFirstShow == false)
            {
                CommonHelper.reloadSettingState = CheckSettingState;
                CheckSettingState();
            }
        }
        //选择存储目录
        private void btnChoose_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.InitialDirectory = @"D:\";
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                txtStorePath.Text = fdb.SelectedPath;
            }
        }

        //选择数据库后缀发生变化(下面三个可以封装，没必要)
        //同步文件名和文件类型
        private void SyncFileType(TextBox txt, ComboBox cboType)
        {
            string fileName = txt.Text.Trim();//文件名
            string selType = cboType.Text.Trim();//选择的类型
            txt.Text = fileName.Split('.')[0] + selType;
        }
        private void cboDbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncFileType(txtDbaseFileName, cboDbTypes);
        }

        private void cboComFileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncFileType(txtCommunicationFileName, cboComFileTypes);
        }

        private void cboAlarmFileTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncFileType(txtAlarmFileName, cboAlarmFileTypes);
        }

        //提交存储按钮的配置 写入文件，处理文件的移动，更新路径信息
        private void btnOK_Click(object sender, EventArgs e)
        {
            //接收信息，检查信息，处理路径信息
            //目录路径
            string storePath = txtStorePath.Text.Trim();
            //数据库文件名
            string dbFileName = txtDbaseFileName.Text.Trim();
            //通信配置文件名
            string communicationFileName = txtCommunicationFileName.Text.Trim();
            //预警配置文件名
            string alarmSetFileName = txtAlarmFileName.Text.Trim();

            //非空判断检查
            if (string.IsNullOrEmpty(storePath)) { lblMsg.SetErrmsg("请选择存储系统相关文件的目录！"); return; }
            if (string.IsNullOrEmpty(dbFileName)) { lblMsg.SetErrmsg("请设置数据库文件名！"); return; }
            if (string.IsNullOrEmpty(communicationFileName)) { lblMsg.SetErrmsg("请设置通信配置文件名！"); return; }
            if (string.IsNullOrEmpty(alarmSetFileName)) { lblMsg.SetErrmsg("请设置预警条件配置文件名！"); return; }

            //处理相关路径信息
            //存储路径信息的文件路径
            string storePathFile = storePath + @"\storeFilePath.txt";
            //文件的完整路径
            string dbFilePath = Path.Combine(storePath, dbFileName);
            string comFilePath = Path.Combine(storePath, communicationFileName);
            string alarmFilePath = Path.Combine(storePath, alarmSetFileName);
            if (storePath == CommonHelper.storePath && dbFilePath ==
            CommonHelper.dbFile && comFilePath == CommonHelper.communicationFile && alarmFilePath == CommonHelper.alarmSetsFile)
            {
                lblMsg.SetErrmsg("当前存储配置信息并未修改！");
                return;
            }
            // 发生改变，写入到storeFilePath.txt文本 文件中
            List<string> msgList = new List<string>();
            msgList.Add("存储目录：" + storePath);
            msgList.Add("数据文件：" + dbFileName);
            msgList.Add("通信配置文件：" + communicationFileName);
            msgList.Add("预警配置文件：" + alarmSetFileName);
            //写入到文件中
            TextHelper.WriteMsgList(msgList, storePathFile, false);
            //如果存储路径发生改变，更新App.Config 
            if (storePath != CommonHelper.storePath)
            {
                AppHelper.SetValue("storePathFile", storePathFile);
                CommonHelper.storePath = storePath;
                CommonHelper.storePathFile = storePathFile;
            }
            //连接字符串也在App.Config  更新
            //原来的连接字符串
            string connStr = AppHelper.GetConnString("connString");
            // 生成新的连接字符串写入到文件中
            string newStr = $"Data Source={dbFilePath}";
            // 处理原有数据库文件，复制到目标处，下次删除系统原有文件
            if ((connStr != "" && connStr != newStr) || connStr == "")
            {
                //写入配置文件
                AppHelper.SetConnString("connString", newStr);
                string oldDbFilePath = CommonHelper.dbFile;
                //处理原有数据库文件：复制到目标位置处、下次使用系统删除原有文件
                if (File.Exists(oldDbFilePath))
                {
                    //复制 暂存原有路径，因为无法一次完成迁移和删除操作
                    File.Copy(oldDbFilePath, dbFileName, true);
                    AppHelper.SetValue("oldDbFile", oldDbFilePath);
                }
                else
                {
                    var fs = File.Create(dbFilePath);
                    fs.Close();
                }
                CommonHelper.dbFile = dbFilePath;
            }
            //如果目录或文件类型改变，移动文件和转换文件格式
            if (comFilePath != CommonHelper.communicationFile && CommonHelper.communicationFile != "") {
                string oldExt = Path.GetExtension(CommonHelper.communicationFile);//原来的扩展名
                string newExt = cboComFileTypes.Text; // 新的扩展名
                string oldComFileName = Path.GetFileNameWithoutExtension(CommonHelper.communicationFile);
                string newComFileName = Path.GetFileNameWithoutExtension(communicationFileName);
                if (oldExt == newExt) {  //如果扩展名称没有变
                    if (File.Exists(CommonHelper.communicationFile)) //存储位置发生变化
                    {
                        File.Move(CommonHelper.communicationFile, comFilePath); //移动到目标位置
                    }
                }
                else if (oldExt != newExt)//扩展名称发生变化，进行判断
                {
                    if (newExt == ".txt")
                    {
                        //将文件转换成txt类型的文件
                        FileConvert.CommunicationSetXMLToTxt(CommonHelper.communicationFile,comFilePath);
                    }
                    else if (newExt == ".xml")
                    {
                        //将文件转换成xml 类型的文件
                        FileConvert.CommunicationSetTxtToXML(CommonHelper.communicationFile, comFilePath);
                    }
                    //删除原来的文件？？
                    File.Delete(CommonHelper.communicationFile);
                }
                //更新通信配置文件路径
                CommonHelper.communicationFile = comFilePath;
            }
            //处理报警配置文件的处理：如果目录或文件类型改变，还移动文件或转换文件格式
            if (alarmFilePath != CommonHelper.alarmSetsFile && CommonHelper.alarmSetsFile != "")
            {
                //原来的扩展名
                string oldExt = Path.GetExtension(CommonHelper.alarmSetsFile);
                //新的扩展名
                string newExt = cboAlarmFileTypes.Text;
                if (oldExt == newExt)
                {
                    //存储位置变了
                    if (File.Exists(CommonHelper.alarmSetsFile))
                    {
                        //移动到目标位置
                        File.Move(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                }
                else if (oldExt != newExt && File.Exists(CommonHelper.alarmSetsFile))
                {
                    if (oldExt == ".txt" && newExt == ".xml")
                    {
                        //将txt格式转换为xml格式
                        FileConvert.AlarmSetsTxtToXML(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    else if (oldExt == ".txt" && newExt == ".json")
                    {
                        //将txt格式转换为json格式
                        FileConvert.AlarmSetsTxtToJson(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    else if (oldExt == ".xml" && newExt == ".txt")
                    {
                        //将xml格式转换为txt格式
                        FileConvert.AlarmSetsXMLToTxt(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    else if (oldExt == ".xml" && newExt == ".json")
                    {
                        //将xml格式转换为json格式
                        FileConvert.AlarmSetsXMLToJson(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    else if (oldExt == ".json" && newExt == ".txt")
                    {
                        //将json格式转换为txt格式
                        FileConvert.AlarmSetsJsonToTxt(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    else if (oldExt == ".json" && newExt == ".xml")
                    {
                        //将json格式转换为xml格式
                        FileConvert.AlarmSetsJsonToXML(CommonHelper.alarmSetsFile, alarmFilePath);
                    }
                    //删除原来的文件
                    File.Delete(CommonHelper.alarmSetsFile);
                }
                //更新报警配置文件路径 
                CommonHelper.alarmSetsFile = alarmFilePath;
            }

            lblMsg.SetSuccmsg("存储配置设置成功！");
        }
    }
}
