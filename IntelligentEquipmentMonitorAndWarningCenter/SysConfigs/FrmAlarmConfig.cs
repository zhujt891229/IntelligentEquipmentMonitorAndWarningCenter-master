using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;
using NPOI.SS.Formula.Functions;
using Zhaoxi.IntelligentDeviceMonitorAndWarningCenter.Models;

namespace IntelligentDeviceMonitorAndWarningCenter.SysConfigs
{
    public partial class FrmAlarmConfig : Form
    {
      
        public FrmAlarmConfig()
        {
            InitializeComponent();
        }
        //保存到配置文件中
        string alarmPath = CommonHelper.alarmSetsFile;
        bool isFirstShow = true;//是否第一次显示

        //加载的时候监听状态
        private void FrmAlarmConfig_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(alarmPath))
            {
                MessageHelper.Warning("加载提示", "当前并未进行存储路径配置，无法进行预警配置！");
                btnOK.Visible = false;//隐藏提交按钮
                return;
            }
            LoadAlarmSets();  //加载配置文件
            //切换到其他页面的时候 改变初始状态
            CommonHelper.reloadSettingState = CheckSettingState;
            CheckSettingState();
            //订阅事件
            foreach (Control c in uGroupPanel.Controls)
            {
                if (c is NumericUpDown || c is TextBox)
                {
                    c.MouseClick += control_MouseClick;
                }

            }
        }

        private void LoadAlarmSets()
        {
            //加载已有配置信息
            AlarmSetInfo setInfo = null;
            if (File.Exists(alarmPath))
            {
                if (CommonHelper.alarmsets == null)
                {
                    //加载配置信息-----从预警配置文件中读取出来
                    FileConvert.LoadAlarmSets();
                }
                setInfo = CommonHelper.alarmsets;
            }
            if (setInfo != null)
            {
                //加载呈现
                AlarmCondition con_T = setInfo.Conditions.Find(c => c.ConditionType == "温度");
                valMin_T.Value = (decimal)con_T.MinValue;
                valMax_T.Value = (decimal)con_T.MaxValue;
                AlarmCondition con_H = setInfo.Conditions.Find(c => c.ConditionType == "湿度");
                valMin_H.Value = (decimal)con_H.MinValue;
                valMax_H.Value = (decimal)con_H.MaxValue;
                AlarmCondition con_B = setInfo.Conditions.Find(c => c.ConditionType == "亮度");
                valMin_B.Value = (decimal)con_B.MinValue;
                valMax_B.Value = (decimal)con_B.MaxValue;

                Grade grade_T = setInfo.Grades.Find(g => g.GradeType == "温度");
                txtGrade_L_T.Text = grade_T.Grade1;
                txtGrade_M_T.Text = grade_T.Grade2;
                txtGrade_H_T.Text = grade_T.Grade3;
                Grade grade_H = setInfo.Grades.Find(g => g.GradeType == "湿度");
                txtGrade_L_H.Text = grade_H.Grade1;
                txtGrade_M_H.Text = grade_H.Grade2;
                txtGrade_H_H.Text = grade_H.Grade3;
                Grade grade_B = setInfo.Grades.Find(g => g.GradeType == "亮度");
                txtGrade_L_B.Text = grade_B.Grade1;
                txtGrade_M_B.Text = grade_B.Grade2;
                txtGrade_H_B.Text = grade_B.Grade3;
            }
            else
            {
                valMin_T.Value = 5;
                valMax_T.Value = 35;
                valMin_H.Value = 30;
                valMax_H.Value = 65;
                valMin_B.Value = 30;
                valMax_B.Value = 75;
                txtGrade_L_T.Text = "低温";
                txtGrade_M_T.Text = "正常";
                txtGrade_H_T.Text = "高温";
                txtGrade_L_H.Text = "干燥";
                txtGrade_M_H.Text = "正常";
                txtGrade_H_H.Text = "潮湿";
                txtGrade_L_B.Text = "黑暗";
                txtGrade_M_B.Text = "正常";
                txtGrade_H_B.Text = "刺眼";
            }
        }

        private void FrmAlarmConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                //同步刷新委托
                CommonHelper.reloadCommunicationState = CheckSettingState;
                //同步启用状态
                CheckSettingState();
            }
        }

        private void CheckSettingState()
        {
            //如果已经启用
            if (CommonHelper.isEnableSetting)
            {
                // 系统配置已启用，禁止修改，显示错误提示并禁用/只读相关控件
                lblMsg.SetErrmsg("预警配置已启用，不能再修改！");
                btnOK.Enabled = false;
                btnOK.Visible = false;
                valMin_T.Enabled = false;
                valMax_T.Enabled = false;
                valMin_H.Enabled = false;
                valMax_H.Enabled = false;
                valMin_B.Enabled = false;
                valMax_B.Enabled = false;
                txtGrade_L_T.Enabled = false;
                txtGrade_M_T.Enabled = false;
                txtGrade_H_T.Enabled = false;
                txtGrade_L_B.Enabled = false;
                txtGrade_M_B.Enabled = false;
                txtGrade_H_B.Enabled = false;
                txtGrade_L_H.Enabled = false;
                txtGrade_M_H.Enabled = false;
                txtGrade_H_H.Enabled = false;
            }
            else
            {
                // 系统未启用配置，允许编辑，显示按钮并启用相关控件
                valMin_T.Enabled = true;
                valMax_T.Enabled = true;
                valMin_H.Enabled = true;
                valMax_H.Enabled = true;
                valMin_B.Enabled = true;
                valMax_B.Enabled = true;
                txtGrade_L_T.Enabled = true;
                txtGrade_M_T.Enabled = true;
                txtGrade_H_T.Enabled = true;
                txtGrade_L_B.Enabled = true;
                txtGrade_M_B.Enabled = true;
                txtGrade_H_B.Enabled = true;
                txtGrade_L_H.Enabled = true;
                txtGrade_M_H.Enabled = true;
                txtGrade_H_H.Enabled = true;
                btnOK.Enabled = true;
                lblMsg.Hide();

            }
        }

        //设置成功应该写入到配置文件中
        private void btnOK_Click(object sender, EventArgs e)
        {
            //阈值获取  
            //温度
            decimal minVal_T = valMin_T.Value;
            decimal maxVal_T = valMax_T.Value;
            //湿度
            decimal minVal_H = valMin_H.Value;
            decimal maxVal_H = valMax_H.Value;
            //亮度
            decimal minVal_B = valMin_B.Value;
            decimal maxVal_B = valMax_B.Value;

            //阈值检查
            if (minVal_T > maxVal_T)
            {
                lblMsg.SetErrmsg("温度的下限值不能大于上限值!");
                return;
            }
            if (minVal_H > maxVal_H)
            {
                lblMsg.SetErrmsg("湿度的下限值不能大于上限值!");
                return;
            }
            if (minVal_B > maxVal_B)
            {
                lblMsg.SetErrmsg("亮度的下限值不能大于上限值!");
                return;
            }
            //等级名称的非空检查
            bool blCheck = true;
            blCheck = CheckGrades(txtGrade_L_T, txtGrade_M_T, txtGrade_H_T, "温度");
            if (!blCheck)
                return;
            blCheck = CheckGrades(txtGrade_L_H, txtGrade_M_H, txtGrade_H_H, "湿度");
            if (!blCheck)
                return;
            blCheck = CheckGrades(txtGrade_L_B, txtGrade_M_B, txtGrade_H_B, "亮度");
            if (!blCheck)
                return;
            //等级名称获取
            //温度
            string grade01_T = txtGrade_L_T.Text.Trim();
            string grade02_T = txtGrade_M_T.Text.Trim();
            string grade03_T = txtGrade_H_T.Text.Trim();
            //湿度
            string grade01_H = txtGrade_L_H.Text.Trim();
            string grade02_H = txtGrade_M_H.Text.Trim();
            string grade03_H = txtGrade_H_H.Text.Trim();
            //亮度
            string grade01_B = txtGrade_L_B.Text.Trim();
            string grade02_B = txtGrade_M_B.Text.Trim();
            string grade03_B = txtGrade_H_B.Text.Trim();
            //转换成指定的格式---字典集合
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            dicConditions.Add("温度", new string[] { $"下限阈值：{minVal_T} ℃", $"上限阈值：{maxVal_T} ℃" });
            dicConditions.Add("湿度", new string[] { $"下限阈值：{minVal_H} %", $"上限阈值：{maxVal_H} %" });
            dicConditions.Add("亮度", new string[] { $"下限阈值：{minVal_B} cd/m2", $"上限阈值：{maxVal_B} cd/m2" });

            dicGrades.Add("温度", $"{grade01_T},{grade02_T},{grade03_T}");
            dicGrades.Add("湿度", $"{grade01_H},{grade02_H},{grade03_H}");
            dicGrades.Add("亮度", $"{grade01_B},{grade02_B},{grade03_B}");

            //写入文件
            string ext = Path.GetExtension(alarmPath);
            switch (ext)
            {
                case ".txt":
                    FileConvert.WriteAlarmSetsToTxt(alarmPath, dicConditions, dicGrades);
                    break;
                case ".xml":
                    FileConvert.WriteAlarmSetsToXML(alarmPath, dicConditions, dicGrades);
                    break;
                case ".json":
                    FileConvert.WriteAlarmSetsToJson(alarmPath, dicConditions, dicGrades);
                    break;
            }
            lblMsg.SetSuccmsg("预警配置保存成功！");
            //更新到静态对象中
            CommonHelper.alarmsets = FileConvert.ConvertToAlarmSet(dicConditions, dicGrades);
        }

        private bool CheckGrades(TextBox txt1, TextBox txt2, TextBox txt3, string type)
        {
            bool blCheck = true;
            blCheck = CheckGradeName(txt1, $"{type}等级1");
            if (!blCheck)
                return false;
            blCheck = CheckGradeName(txt2, $"{type}等级2");
            if (!blCheck)
                return false;
            blCheck = CheckGradeName(txt3, $"{type}等级3");
            if (!blCheck)
                return false;
            return blCheck;
        }

        private bool CheckGradeName(TextBox txt, string msg)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                lblMsg.SetErrmsg($"{msg}的名称不能为空！");
                txt.Focus();
                return false;
            }
            return true;
        }

        private void control_MouseClick(object sender, MouseEventArgs e)
        {
            lblMsg.Hide();
        }
    }
}
