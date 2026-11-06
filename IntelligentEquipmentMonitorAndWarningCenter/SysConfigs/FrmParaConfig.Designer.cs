namespace IntelligentDeviceMonitorAndWarningCenter.SysConfigs
{
    partial class FrmParaConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            uGroupPanel31 = new Zhaoxi.CustControls.UGroupPanel3();
            dgvParaList = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colFunctionCode = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colDeCount = new DataGridViewTextBoxColumn();
            colDataType = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colNote = new DataGridViewTextBoxColumn();
            numDecCount = new NumericUpDown();
            uLine1 = new Zhaoxi.CustControls.ULine();
            lblDelMsg = new Label();
            lblMsg = new Label();
            cboUnit = new ComboBox();
            cboDataTypes = new ComboBox();
            cboFunctions = new ComboBox();
            cboParaTypes = new ComboBox();
            btnDelete = new Zhaoxi.CustControls.UButton();
            btnAdd = new Zhaoxi.CustControls.UButton();
            btnOK = new Zhaoxi.CustControls.UButton();
            txtNote = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtParaName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            uGroupPanel31.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParaList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDecCount).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel31
            // 
            uGroupPanel31.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel31.Background = Color.FromArgb(25, 55, 87);
            uGroupPanel31.Controls.Add(dgvParaList);
            uGroupPanel31.Controls.Add(numDecCount);
            uGroupPanel31.Controls.Add(uLine1);
            uGroupPanel31.Controls.Add(lblDelMsg);
            uGroupPanel31.Controls.Add(lblMsg);
            uGroupPanel31.Controls.Add(cboUnit);
            uGroupPanel31.Controls.Add(cboDataTypes);
            uGroupPanel31.Controls.Add(cboFunctions);
            uGroupPanel31.Controls.Add(cboParaTypes);
            uGroupPanel31.Controls.Add(btnDelete);
            uGroupPanel31.Controls.Add(btnAdd);
            uGroupPanel31.Controls.Add(btnOK);
            uGroupPanel31.Controls.Add(txtNote);
            uGroupPanel31.Controls.Add(label7);
            uGroupPanel31.Controls.Add(label6);
            uGroupPanel31.Controls.Add(label5);
            uGroupPanel31.Controls.Add(label4);
            uGroupPanel31.Controls.Add(txtAddress);
            uGroupPanel31.Controls.Add(label3);
            uGroupPanel31.Controls.Add(txtParaName);
            uGroupPanel31.Controls.Add(label2);
            uGroupPanel31.Controls.Add(label1);
            uGroupPanel31.CornerRadius = 5;
            uGroupPanel31.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel31.Location = new Point(15, 16);
            uGroupPanel31.Margin = new Padding(4);
            uGroupPanel31.Name = "uGroupPanel31";
            uGroupPanel31.Padding = new Padding(4);
            uGroupPanel31.PrimaryColor = Color.White;
            uGroupPanel31.Size = new Size(1552, 754);
            uGroupPanel31.TabIndex = 1;
            uGroupPanel31.TabStop = false;
            uGroupPanel31.Text = "系统参数配置";
            // 
            // dgvParaList
            // 
            dgvParaList.AllowUserToAddRows = false;
            dgvParaList.AllowUserToDeleteRows = false;
            dgvParaList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvParaList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvParaList.BackgroundColor = Color.FromArgb(25, 55, 87);
            dgvParaList.BorderStyle = BorderStyle.None;
            dgvParaList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvParaList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvParaList.ColumnHeadersHeight = 40;
            dgvParaList.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colType, colFunctionCode, colAddress, colDeCount, colDataType, colUnit, colNote });
            dgvParaList.EnableHeadersVisualStyles = false;
            dgvParaList.GridColor = Color.SlateGray;
            dgvParaList.Location = new Point(424, 112);
            dgvParaList.Margin = new Padding(4);
            dgvParaList.Name = "dgvParaList";
            dgvParaList.RowHeadersVisible = false;
            dgvParaList.RowHeadersWidth = 51;
            dgvParaList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvParaList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(28, 70, 102);
            dgvParaList.RowTemplate.DefaultCellStyle.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgvParaList.RowTemplate.DefaultCellStyle.ForeColor = Color.Silver;
            dgvParaList.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvParaList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 95, 118);
            dgvParaList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvParaList.RowTemplate.Height = 35;
            dgvParaList.RowTemplate.ReadOnly = true;
            dgvParaList.ScrollBars = ScrollBars.Vertical;
            dgvParaList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvParaList.Size = new Size(1121, 631);
            dgvParaList.TabIndex = 8;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.FillWeight = 60F;
            colId.HeaderText = "编号";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "ParaName";
            colName.HeaderText = "参数名";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colType
            // 
            colType.DataPropertyName = "ParaType";
            colType.HeaderText = "参数类别";
            colType.MinimumWidth = 6;
            colType.Name = "colType";
            colType.ReadOnly = true;
            // 
            // colFunctionCode
            // 
            colFunctionCode.DataPropertyName = "FunctionCode";
            colFunctionCode.FillWeight = 80F;
            colFunctionCode.HeaderText = "功能码";
            colFunctionCode.MinimumWidth = 6;
            colFunctionCode.Name = "colFunctionCode";
            colFunctionCode.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "访问地址";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // colDeCount
            // 
            colDeCount.DataPropertyName = "DeCount";
            colDeCount.HeaderText = "小数位数";
            colDeCount.MinimumWidth = 6;
            colDeCount.Name = "colDeCount";
            colDeCount.ReadOnly = true;
            // 
            // colDataType
            // 
            colDataType.DataPropertyName = "DataType";
            colDataType.HeaderText = "数据类型";
            colDataType.MinimumWidth = 6;
            colDataType.Name = "colDataType";
            colDataType.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.DataPropertyName = "Unit";
            colUnit.HeaderText = "数据单位";
            colUnit.MinimumWidth = 6;
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colNote
            // 
            colNote.DataPropertyName = "Note";
            colNote.FillWeight = 200F;
            colNote.HeaderText = "参数描述";
            colNote.MinimumWidth = 6;
            colNote.Name = "colNote";
            colNote.ReadOnly = true;
            // 
            // numDecCount
            // 
            numDecCount.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            numDecCount.Location = new Point(150, 269);
            numDecCount.Margin = new Padding(4);
            numDecCount.Name = "numDecCount";
            numDecCount.Size = new Size(112, 31);
            numDecCount.TabIndex = 7;
            numDecCount.TextAlign = HorizontalAlignment.Center;
            numDecCount.ValueChanged += numDecCount_ValueChanged;
            // 
            // uLine1
            // 
            uLine1.IsHorizontal = false;
            uLine1.Location = new Point(402, 53);
            uLine1.Margin = new Padding(4);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(15, 690);
            uLine1.TabIndex = 6;
            uLine1.Text = "uLine1";
            // 
            // lblDelMsg
            // 
            lblDelMsg.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDelMsg.BackColor = Color.Transparent;
            lblDelMsg.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblDelMsg.ForeColor = Color.Red;
            lblDelMsg.Location = new Point(801, 53);
            lblDelMsg.Margin = new Padding(4, 0, 4, 0);
            lblDelMsg.Name = "lblDelMsg";
            lblDelMsg.Size = new Size(744, 48);
            lblDelMsg.TabIndex = 5;
            lblDelMsg.Text = "请选择要删除的参数信息！";
            lblDelMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Orange;
            lblMsg.Location = new Point(37, 613);
            lblMsg.Margin = new Padding(4, 0, 4, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(357, 100);
            lblMsg.TabIndex = 5;
            lblMsg.Text = "设置成功！";
            // 
            // cboUnit
            // 
            cboUnit.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboUnit.FormattingEnabled = true;
            cboUnit.Items.AddRange(new object[] { "", "℃", "%", "cd/m2" });
            cboUnit.Location = new Point(147, 398);
            cboUnit.Margin = new Padding(4);
            cboUnit.Name = "cboUnit";
            cboUnit.Size = new Size(223, 32);
            cboUnit.TabIndex = 4;
            // 
            // cboDataTypes
            // 
            cboDataTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboDataTypes.FormattingEnabled = true;
            cboDataTypes.Items.AddRange(new object[] { "double", "decimal", "int", "ushort", "bool" });
            cboDataTypes.Location = new Point(147, 334);
            cboDataTypes.Margin = new Padding(4);
            cboDataTypes.Name = "cboDataTypes";
            cboDataTypes.Size = new Size(223, 32);
            cboDataTypes.TabIndex = 4;
            // 
            // cboFunctions
            // 
            cboFunctions.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboFunctions.FormattingEnabled = true;
            cboFunctions.Items.AddRange(new object[] { "", "1", "2", "3", "4" });
            cboFunctions.Location = new Point(147, 203);
            cboFunctions.Margin = new Padding(4);
            cboFunctions.Name = "cboFunctions";
            cboFunctions.Size = new Size(115, 32);
            cboFunctions.TabIndex = 4;
            // 
            // cboParaTypes
            // 
            cboParaTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboParaTypes.FormattingEnabled = true;
            cboParaTypes.Items.AddRange(new object[] { "实时数据", "灯珠状态", "历史数据" });
            cboParaTypes.Location = new Point(147, 67);
            cboParaTypes.Margin = new Padding(4);
            cboParaTypes.Name = "cboParaTypes";
            cboParaTypes.Size = new Size(223, 32);
            cboParaTypes.TabIndex = 4;
            cboParaTypes.SelectedIndexChanged += cboParaTypes_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.BgColor = Color.FromArgb(192, 0, 0);
            btnDelete.BorderColor = Color.FromArgb(25, 55, 87);
            btnDelete.BorderWidth = 1;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FocusBgColor = Color.Maroon;
            btnDelete.FocusForeColor = Color.White;
            btnDelete.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(611, 53);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(143, 48);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "删除参数";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BgColor = Color.DodgerBlue;
            btnAdd.BorderColor = Color.FromArgb(25, 55, 87);
            btnAdd.BorderWidth = 1;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FocusBgColor = Color.SteelBlue;
            btnAdd.FocusForeColor = Color.White;
            btnAdd.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(445, 53);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 48);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "添加参数";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnOK
            // 
            btnOK.BgColor = Color.DarkOrange;
            btnOK.BgColor2 = Color.Orange;
            btnOK.BorderColor = Color.FromArgb(25, 55, 87);
            btnOK.BorderWidth = 1;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOK.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.FocusBgColor = Color.DarkOrange;
            btnOK.FocusForeColor = Color.White;
            btnOK.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(150, 539);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(143, 48);
            btnOK.TabIndex = 3;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // txtNote
            // 
            txtNote.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtNote.Location = new Point(147, 464);
            txtNote.Margin = new Padding(4);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(223, 31);
            txtNote.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(37, 469);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 1;
            label7.Text = "参数描述：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(37, 403);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 1;
            label6.Text = "数据单位：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(37, 338);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 1;
            label5.Text = "数据类型：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(37, 275);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 1;
            label4.Text = "小数位数：";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtAddress.Location = new Point(275, 204);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(94, 31);
            txtAddress.TabIndex = 3;
            txtAddress.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(37, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 1;
            label3.Text = "存储地址：";
            // 
            // txtParaName
            // 
            txtParaName.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtParaName.Location = new Point(147, 133);
            txtParaName.Margin = new Padding(4);
            txtParaName.Name = "txtParaName";
            txtParaName.Size = new Size(223, 31);
            txtParaName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(55, 138);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 1;
            label2.Text = "参数名：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(73, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 1;
            label1.Text = "类别：";
            // 
            // FrmParaConfig
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1582, 782);
            Controls.Add(uGroupPanel31);
            Margin = new Padding(4);
            Name = "FrmParaConfig";
            Text = "FrmParaConfig";
            Load += FrmParaConfig_Load;
            VisibleChanged += FrmParaConfig_VisibleChanged;
            uGroupPanel31.ResumeLayout(false);
            uGroupPanel31.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParaList).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDecCount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel3 uGroupPanel31;
        private Zhaoxi.CustControls.ULine uLine1;
        private Label lblMsg;
        private ComboBox cboDataTypes;
        private ComboBox cboFunctions;
        private ComboBox cboParaTypes;
        private Zhaoxi.CustControls.UButton btnOK;
        private TextBox txtNote;
        private Label label4;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtParaName;
        private Label label2;
        private Label label1;
        private NumericUpDown numDecCount;
        private Label label5;
        private ComboBox cboUnit;
        private Label label7;
        private Label label6;
        private DataGridView dgvParaList;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colFunctionCode;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colDeCount;
        private DataGridViewTextBoxColumn colDataType;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colNote;
        private Zhaoxi.CustControls.UButton btnDelete;
        private Zhaoxi.CustControls.UButton btnAdd;
        private Label lblDelMsg;
    }
}