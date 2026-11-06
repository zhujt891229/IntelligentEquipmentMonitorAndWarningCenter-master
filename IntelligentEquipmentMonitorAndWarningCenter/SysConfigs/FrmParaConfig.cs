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
using IntelligentEquipmentMonitorAndWarningCenter;
using IntelligentEquipmentMonitorAndWarningCenter.Utils;

namespace IntelligentDeviceMonitorAndWarningCenter.SysConfigs
{
    /// <summary>
    /// 参数配置窗体，用于管理设备监控参数的增删改查及配置项编辑
    /// </summary>
    public partial class FrmParaConfig : Form
    {
        public FrmParaConfig()
        {
            InitializeComponent();
        }

        // 参数业务逻辑层对象，用于操作参数数据
        ParaBLL paraBLL = new ParaBLL();

        // 设置编辑状态标识（true 表示编辑模式，false 表示新增模式）
        bool isEdit = false;

        bool isFirstShow = true; //是否第一次显示

        ParaInfo editPara = null;//修改前的参数信息
        /// <summary>
        /// 参数配置页面的初始化：初始化信息栏、加载参数列表、同步设置状态
        /// </summary>
        private void FrmParaConfig_Load(object sender, EventArgs e)
        {

            //信息栏初始化
            InitParaInfo();
            //加载已有参数列表
            //LoadParaList();
            //同步启用设置状态
            CommonHelper.reloadSettingState = CheckSettingState;
            //检查设置状态
            CheckSettingState();
        }

        //信息栏初始化
        private void InitParaInfo()
        {
            cboParaTypes.SelectedIndex = 0;//默认选择实时数据
            txtParaName.Clear();
            cboFunctions.SelectedItem = "3";//默认选择3
            txtAddress.Text = "0";
            numDecCount.Value = 1;
            cboDataTypes.SelectedItem = "double";
            cboUnit.SelectedItem = "℃";
            txtNote.Clear();
            btnOK.Text = "新增";
            lblMsg.Hide();
            btnAdd.Hide();
        }

        //加载已有参数列表
        private void LoadParaList()
        {
            dgvParaList.AutoGenerateColumns = false;
            var paraList = paraBLL.GetAllParaList();
            if (paraList != null)
            {
                dgvParaList.DataSource = paraList;
                dgvParaList.ClearSelection();
            }
            else
            {
                dgvParaList.DataSource = null;
            }
        }


        //检查设置状态
        private void CheckSettingState()
        {
            if (CommonHelper.isEnableSetting)
            {
                lblMsg.SetErrmsg("系统配置已启用，不能再修改！");
                btnAdd.Visible = false;
                btnOK.Visible = false;
                btnDelete.Visible = false;
                txtParaName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtNote.ReadOnly = true;
                numDecCount.Enabled = false;
                cboDataTypes.Enabled = false;
                cboFunctions.Enabled = false;
                cboDataTypes.Enabled = false;
                cboUnit.Enabled = false;
            }
            else
            {
                btnOK.Visible = true;
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                txtParaName.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtNote.ReadOnly = false;
                numDecCount.Enabled = true;
                cboDataTypes.Enabled = true;
                cboFunctions.Enabled = true;
                cboDataTypes.Enabled = true;
                cboUnit.Enabled = true;
                lblMsg.Visible = false;

            }
        }
        private void FrmParaConfig_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false && isFirstShow == true)
                isFirstShow = false;
            else if (this.Visible && isFirstShow == false)
            {
                CommonHelper.reloadSettingState = CheckSettingState;
                CheckSettingState();
            }
            if (this.Visible && isFirstShow)
                LoadParaList();
        }

        /// <summary>
        /// 参数选择切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboParaTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //索引值  0实时数据   1灯珠状态   2历史数据
            int selIndex = cboParaTypes.SelectedIndex;
            if (selIndex == 1)
            {
                cboDataTypes.Items.Add("bool");
                cboDataTypes.Enabled = false;
                cboUnit.SelectedItem = "";
                cboUnit.Enabled = false;
                numDecCount.Value = 0;
                numDecCount.Enabled = false;
                cboFunctions.SelectedItem = "1";
                cboFunctions.Enabled = false;
                cboDataTypes.SelectedItem = "bool";
            }
            else
            {
                if (selIndex == 0)
                {
                    cboFunctions.SelectedItem = "3";
                    cboFunctions.Enabled = false;
                    txtAddress.Text = "0";
                    txtAddress.Enabled = true;
                }
                else if (selIndex == 2)
                {
                    cboFunctions.SelectedItem = "";
                    cboFunctions.Enabled = false;
                    txtAddress.Text = "";
                    txtAddress.Enabled = false;
                }
                cboDataTypes.Items.Remove("bool");
                cboDataTypes.SelectedItem = "double";
                cboDataTypes.Enabled = true;
                cboUnit.SelectedItem = "℃";
                cboUnit.Enabled = true;
                numDecCount.Value = 1;
                numDecCount.Enabled = true;
            }
        }



        /// <summary>
        /// 小数位数改变处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numDecCount_ValueChanged(object sender, EventArgs e)
        {
            int val = (int)numDecCount.Value;
            if (val == 0 && cboParaTypes.SelectedIndex != 1)
            {
                cboDataTypes.SelectedItem = "ushort";
            }
            else if (val > 0)
            {
                cboDataTypes.SelectedItem = "double";
            }

        }

        /// <summary>
        /// 添加------信息栏切换回新增状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isEdit = false;//切换为新增状态
            InitParaInfo();//初始化信息栏
        }


        /// <summary>
        /// 参数删除处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvParaList.SelectedRows.Count > 0)
            {
                if (MessageHelper.Confirm("删除提示", "你确定要删除选择的参数信息吗？") == DialogResult.OK)
                {
                    bool blDelete = false;
                    List<ParaInfo> delList = new List<ParaInfo>();
                    if (dgvParaList.SelectedRows.Count == 1)
                    {
                        //单个删除
                        ParaInfo para = dgvParaList.SelectedRows[0].DataBoundItem as ParaInfo;
                        int paraId = para.Id;
                        delList.Add(para);
                        blDelete = paraBLL.DeletePara(paraId);//调用单个删除方法
                    }
                    else
                    {
                        List<int> delIds = new List<int>();
                        foreach (DataGridViewRow dr in dgvParaList.SelectedRows)
                        {
                            ParaInfo para = dr.DataBoundItem as ParaInfo;
                            delIds.Add(para.Id);
                            delList.Add(para);
                        }
                        blDelete = paraBLL.DeleteParas(delIds);//调用多个删除方法
                    }
                    //处理删除结果
                    if (blDelete)
                    {
                        lblDelMsg.SetSuccmsg("选择的参数信息删除成功！");
                        //刷新参数列表
                        var list = dgvParaList.DataSource as List<ParaInfo>;
                        dgvParaList.DataSource = null;//断开数据源
                        delList.ForEach(p => list.Remove(p));//移除已删除的数据
                        dgvParaList.DataSource = list;//重新绑定
                    }
                    else
                    {
                        lblDelMsg.SetErrmsg("选择的参数信息删除失败！");
                        dgvParaList.ClearSelection();
                        return;
                    }
                }
                else
                {
                    dgvParaList.ClearSelection();//清除选择
                }
            }
            else
            {
                lblDelMsg.SetErrmsg("请先选择要删除的参数信息！");
                return;
            }
        }

        int selRowIndex = -1;//双击行的索引
        /// <summary>
        /// 行双击事件----加载行信息到左侧的信息栏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvParaList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                selRowIndex = e.RowIndex;
                ParaInfo para = dgvParaList.Rows[selRowIndex].DataBoundItem as ParaInfo;
                if (para != null)
                {
                    isEdit = true;
                    editPara = para;
                    txtParaName.Text = para.ParaName;
                    cboParaTypes.SelectedIndex = para.ParaType;

                    if (para.ParaType == 2)//类别：历史数据
                    {
                        cboFunctions.SelectedItem = "";
                        txtAddress.Text = "";
                        cboFunctions.Enabled = false;
                        txtAddress.ReadOnly = true;
                    }
                    else
                    {
                        cboFunctions.SelectedItem = para.FunctionCode.ToString();
                        cboFunctions.Enabled = false;
                        txtAddress.Text = para.Address.ToString();
                        txtAddress.ReadOnly = false;
                        if (para.ParaType == 1)
                        {
                            cboDataTypes.Enabled = false;
                            numDecCount.Enabled = false;
                        }
                        else if (para.ParaType == 0)
                        {
                            cboDataTypes.Enabled = true;
                            numDecCount.Enabled = true;
                            cboUnit.Enabled = true;
                        }

                    }
                    numDecCount.Value = para.DCount;
                    cboDataTypes.SelectedItem = para.DataType;
                    cboUnit.SelectedItem = para.Unit;
                    txtNote.Text = para.Note;
                    btnOK.Text = "修改";
                    btnAdd.Visible = true;//显示添加按钮
                }
            }
        }

        /// <summary>
        /// 参数信息提交处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //接收录入或编辑的参数信息
            int paraType = cboParaTypes.SelectedIndex;//参数类别编号
            string paraName = txtParaName.Text.Trim();//参数名
            byte.TryParse(cboFunctions.Text, out byte functionCode);//功能码
            ushort.TryParse(txtAddress.Text, out ushort address);//地址
            int dcount = Convert.ToInt32(numDecCount.Value);//小数位数
            string dataType = cboDataTypes.Text.Trim();//数据类型
            string unit = cboUnit.Text.Trim();//单位
            string note = txtNote.Text.Trim();//描述

            //检查信息：非空检查、参数名存在性、检查数据的存储是否与其他的地址相同
            if (string.IsNullOrEmpty(paraName))
            {
                lblMsg.SetErrmsg("请设置参数名！");
                return;
            }
            else if (isEdit == false || (isEdit && paraName != editPara.ParaName))
            {
                if (paraBLL.ExistParaName(paraName))
                {
                    lblMsg.SetErrmsg("该参数名已存在，不能重复添加相同名称的参数！");
                    return;
                }
            }
            if (functionCode > 0 && address < 0)
            {
                lblMsg.SetErrmsg("请设置正确的地址！");
                return;
            }
            else if (isEdit == false || (isEdit && paraName != editPara.ParaName))
            {
                if (paraBLL.ExistByFuctionCodeAndAddress(functionCode, address))
                {
                    lblMsg.SetErrmsg("该存储地址已存在，两个不同数据不能是相同的地址！");
                    return;
                }
            }
            if (string.IsNullOrEmpty(unit) && cboParaTypes.SelectedIndex != 1)
            {
                lblMsg.SetErrmsg("请设置数据单位！");
                return;
            }
            if (string.IsNullOrEmpty(note))
            {
                lblMsg.SetErrmsg("请设置参数描述！");
                return;
            }

            //封装信息
            ParaInfo paraInfo = new ParaInfo()
            {
                ParaName = paraName,
                FunctionCode = functionCode,
                Address = address,
                DCount = dcount,
                DataType = dataType,
                Unit = unit,
                Note = note,
                ParaType = paraType,
                ParaTypeName = cboParaTypes.Text
            };
            //提交处理：添加、修改
            if (isEdit == false)
            {
                int paraId = paraBLL.AddPara(paraInfo);//新增参数
                if (paraId > 0)
                {
                    paraInfo.Id = paraId;//更新编号
                    lblMsg.SetSuccmsg($"参数：{paraName} 信息新增成功！");
                    //刷新到列表中
                    var list = dgvParaList.DataSource as List<ParaInfo>;
                    dgvParaList.DataSource = null;//断开 数据源
                    if (list == null)
                        list = new List<ParaInfo>();
                    list.Add(paraInfo);
                    dgvParaList.DataSource = list;//重新绑定
                }
                else
                {
                    lblMsg.SetErrmsg($"参数：{paraName} 信息新增失败！");
                    return;
                }
            }
            else
            {
                paraInfo.Id = editPara.Id;
                bool blEdit = paraBLL.EditPara(paraInfo);
                if (blEdit)
                {
                    lblMsg.SetErrmsg($"参数：{paraName} 信息修改成功！");
                    //刷新到列表中
                    var list = dgvParaList.DataSource as List<ParaInfo>;
                    dgvParaList.DataSource = null;//断开 数据源
                    list[selRowIndex] = paraInfo;
                    dgvParaList.DataSource = list;//重新绑定
                }
                else
                {
                    lblMsg.SetErrmsg($"参数：{paraName} 信息修改失败！");
                    return;
                }
            }

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(TextBox) || sender.GetType() == typeof(ComboBox))
            {
                Control txt = (Control)sender;
                if (txt.Text.Trim().Length > 0)
                {
                    lblMsg.Hide();
                }
            }

        }

        private void dgvParaList_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvParaList.DataSource != null)
            {
                foreach (DataGridViewRow row in dgvParaList.Rows)
                {
                    ParaInfo para = row.DataBoundItem as ParaInfo;
                    if (para.FunctionCode == 0 && para.Address == 0)
                    {
                        Color bgColor = row.DefaultCellStyle.BackColor;
                        Color selBgColor = row.DefaultCellStyle.SelectionBackColor;
                        row.Cells["colFunctionCode"].Style.ForeColor = bgColor;
                        row.Cells["colAddress"].Style.ForeColor = bgColor;
                        row.Cells["colFunctionCode"].Style.SelectionForeColor = selBgColor;
                        row.Cells["colAddress"].Style.SelectionForeColor = selBgColor;
                    }
                }
            }

        }

        /// <summary>
        /// 隐藏错误提示消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvParaList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvParaList.SelectedRows.Count > 0 && lblDelMsg.Visible)
                lblDelMsg.Visible = false;
        }

    }
}