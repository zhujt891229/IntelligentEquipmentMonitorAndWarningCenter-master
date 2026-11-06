namespace IntelligentDeviceMonitorAndWarningCenter
{
    partial class FrmAlarmManage
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            uGroupPanel21 = new Zhaoxi.CustControls.UGroupPanel2();
            btnFind = new Zhaoxi.CustControls.UButton();
            dtEndTime = new DateTimePicker();
            dtStartTime = new DateTimePicker();
            cboInfoTypes = new ComboBox();
            panelAlarmStates = new Panel();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            rbtnHistoryAlarm = new RadioButton();
            rbtnRealTimeAlarm = new RadioButton();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            uLine6 = new Zhaoxi.CustControls.ULine();
            dgvAlarmLogList = new DataGridView();
            colChk = new DataGridViewCheckBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colAlarmTime = new DataGridViewTextBoxColumn();
            colInfoName = new DataGridViewTextBoxColumn();
            colAlarmType = new DataGridViewTextBoxColumn();
            colAlarmState = new DataGridViewTextBoxColumn();
            colAlarmValue = new DataGridViewTextBoxColumn();
            colAlarmNote = new DataGridViewTextBoxColumn();
            lblDelMsg = new Label();
            btnDelete = new Zhaoxi.CustControls.UButton();
            pager = new Zhaoxi.CustControls.UPager();
            uGroupPanel21.SuspendLayout();
            panelAlarmStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarmLogList).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel21
            // 
            uGroupPanel21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel21.Background = Color.Black;
            uGroupPanel21.Controls.Add(btnFind);
            uGroupPanel21.Controls.Add(dtEndTime);
            uGroupPanel21.Controls.Add(dtStartTime);
            uGroupPanel21.Controls.Add(cboInfoTypes);
            uGroupPanel21.Controls.Add(panelAlarmStates);
            uGroupPanel21.Controls.Add(rbtnHistoryAlarm);
            uGroupPanel21.Controls.Add(rbtnRealTimeAlarm);
            uGroupPanel21.Controls.Add(label3);
            uGroupPanel21.Controls.Add(label6);
            uGroupPanel21.Controls.Add(label5);
            uGroupPanel21.Controls.Add(label4);
            uGroupPanel21.Controls.Add(label2);
            uGroupPanel21.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel21.Location = new Point(6, 14);
            uGroupPanel21.Margin = new Padding(4);
            uGroupPanel21.Name = "uGroupPanel21";
            uGroupPanel21.Padding = new Padding(4);
            uGroupPanel21.PrimaryColor = Color.SkyBlue;
            uGroupPanel21.Size = new Size(1613, 174);
            uGroupPanel21.TabIndex = 0;
            uGroupPanel21.TabStop = false;
            uGroupPanel21.Text = "报警查询条件";
            // 
            // btnFind
            // 
            btnFind.BgColor = Color.FromArgb(255, 128, 0);
            btnFind.BgColor2 = Color.FromArgb(255, 192, 128);
            btnFind.BorderColor = Color.FromArgb(25, 55, 87);
            btnFind.BorderWidth = 1;
            btnFind.FlatAppearance.BorderSize = 0;
            btnFind.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFind.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.FocusBgColor = Color.FromArgb(192, 64, 0);
            btnFind.FocusForeColor = Color.White;
            btnFind.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(1331, 109);
            btnFind.Margin = new Padding(4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(90, 42);
            btnFind.TabIndex = 7;
            btnFind.Text = "查询";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // dtEndTime
            // 
            dtEndTime.CalendarFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtEndTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.Location = new Point(1049, 114);
            dtEndTime.Margin = new Padding(4);
            dtEndTime.Name = "dtEndTime";
            dtEndTime.Size = new Size(237, 31);
            dtEndTime.TabIndex = 6;
            // 
            // dtStartTime
            // 
            dtStartTime.CalendarFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtStartTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.Location = new Point(737, 114);
            dtStartTime.Margin = new Padding(4);
            dtStartTime.Name = "dtStartTime";
            dtStartTime.Size = new Size(237, 31);
            dtStartTime.TabIndex = 6;
            // 
            // cboInfoTypes
            // 
            cboInfoTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboInfoTypes.FormattingEnabled = true;
            cboInfoTypes.Items.AddRange(new object[] { "全部", "温度", "湿度", "亮度" });
            cboInfoTypes.Location = new Point(175, 114);
            cboInfoTypes.Margin = new Padding(4);
            cboInfoTypes.Name = "cboInfoTypes";
            cboInfoTypes.Size = new Size(184, 32);
            cboInfoTypes.TabIndex = 5;
            // 
            // panelAlarmStates
            // 
            panelAlarmStates.BackColor = Color.Transparent;
            panelAlarmStates.Controls.Add(checkBox4);
            panelAlarmStates.Controls.Add(checkBox3);
            panelAlarmStates.Controls.Add(checkBox2);
            panelAlarmStates.Controls.Add(checkBox1);
            panelAlarmStates.Location = new Point(733, 44);
            panelAlarmStates.Margin = new Padding(4);
            panelAlarmStates.Name = "panelAlarmStates";
            panelAlarmStates.Size = new Size(792, 54);
            panelAlarmStates.TabIndex = 4;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBox4.ForeColor = Color.White;
            checkBox4.Location = new Point(446, 12);
            checkBox4.Margin = new Padding(4);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(144, 28);
            checkBox4.TabIndex = 0;
            checkBox4.Tag = "1";
            checkBox4.Text = "取消低值异常";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBox3.ForeColor = Color.White;
            checkBox3.Location = new Point(274, 13);
            checkBox3.Margin = new Padding(4);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(144, 28);
            checkBox3.TabIndex = 0;
            checkBox3.Tag = "3";
            checkBox3.Text = "取消高值异常";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(141, 13);
            checkBox2.Margin = new Padding(4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(108, 28);
            checkBox2.TabIndex = 0;
            checkBox2.Tag = "0";
            checkBox2.Text = "低值异常";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(9, 13);
            checkBox1.Margin = new Padding(4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 28);
            checkBox1.TabIndex = 0;
            checkBox1.Tag = "2";
            checkBox1.Text = "高值异常";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // rbtnHistoryAlarm
            // 
            rbtnHistoryAlarm.AutoSize = true;
            rbtnHistoryAlarm.BackColor = Color.Transparent;
            rbtnHistoryAlarm.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnHistoryAlarm.ForeColor = Color.Silver;
            rbtnHistoryAlarm.Location = new Point(320, 58);
            rbtnHistoryAlarm.Margin = new Padding(4);
            rbtnHistoryAlarm.Name = "rbtnHistoryAlarm";
            rbtnHistoryAlarm.Size = new Size(109, 29);
            rbtnHistoryAlarm.TabIndex = 3;
            rbtnHistoryAlarm.Text = "历史报警";
            rbtnHistoryAlarm.UseVisualStyleBackColor = false;
            // 
            // rbtnRealTimeAlarm
            // 
            rbtnRealTimeAlarm.AutoSize = true;
            rbtnRealTimeAlarm.BackColor = Color.Transparent;
            rbtnRealTimeAlarm.Checked = true;
            rbtnRealTimeAlarm.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnRealTimeAlarm.ForeColor = Color.SteelBlue;
            rbtnRealTimeAlarm.Location = new Point(175, 58);
            rbtnRealTimeAlarm.Margin = new Padding(4);
            rbtnRealTimeAlarm.Name = "rbtnRealTimeAlarm";
            rbtnRealTimeAlarm.Size = new Size(109, 29);
            rbtnRealTimeAlarm.TabIndex = 3;
            rbtnRealTimeAlarm.TabStop = true;
            rbtnRealTimeAlarm.Text = "实时报警";
            rbtnRealTimeAlarm.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(48, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 24);
            label3.TabIndex = 2;
            label3.Text = "报警来源：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(997, 120);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(23, 24);
            label6.TabIndex = 2;
            label6.Text = "~";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(623, 118);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 2;
            label5.Text = "查询时间：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(623, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 2;
            label4.Text = "报警状态：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(48, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "报警类别：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("黑体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(27, 226);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 12;
            label1.Text = "报警记录";
            // 
            // uLine6
            // 
            uLine6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine6.LineColor = Color.SlateGray;
            uLine6.Location = new Point(12, 251);
            uLine6.Margin = new Padding(4);
            uLine6.Name = "uLine6";
            uLine6.Size = new Size(1599, 13);
            uLine6.TabIndex = 11;
            uLine6.Text = "uLine5";
            // 
            // dgvAlarmLogList
            // 
            dgvAlarmLogList.AllowUserToAddRows = false;
            dgvAlarmLogList.AllowUserToDeleteRows = false;
            dgvAlarmLogList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAlarmLogList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlarmLogList.BackgroundColor = Color.FromArgb(25, 55, 87);
            dgvAlarmLogList.BorderStyle = BorderStyle.None;
            dgvAlarmLogList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlarmLogList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlarmLogList.ColumnHeadersHeight = 40;
            dgvAlarmLogList.Columns.AddRange(new DataGridViewColumn[] { colChk, colId, colAlarmTime, colInfoName, colAlarmType, colAlarmState, colAlarmValue, colAlarmNote });
            dgvAlarmLogList.EnableHeadersVisualStyles = false;
            dgvAlarmLogList.GridColor = Color.SlateGray;
            dgvAlarmLogList.Location = new Point(15, 271);
            dgvAlarmLogList.Margin = new Padding(4);
            dgvAlarmLogList.Name = "dgvAlarmLogList";
            dgvAlarmLogList.RowHeadersVisible = false;
            dgvAlarmLogList.RowHeadersWidth = 51;
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(44, 78, 100);
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.ForeColor = Color.Silver;
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 78, 110);
            dgvAlarmLogList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvAlarmLogList.RowTemplate.Height = 35;
            dgvAlarmLogList.RowTemplate.ReadOnly = true;
            dgvAlarmLogList.ScrollBars = ScrollBars.Vertical;
            dgvAlarmLogList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlarmLogList.Size = new Size(1596, 634);
            dgvAlarmLogList.TabIndex = 13;
            // 
            // colChk
            // 
            colChk.FillWeight = 50F;
            colChk.HeaderText = "选择";
            colChk.MinimumWidth = 6;
            colChk.Name = "colChk";
            // 
            // colId
            // 
            colId.DataPropertyName = "LogId";
            colId.FillWeight = 60F;
            colId.HeaderText = "编号";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colAlarmTime
            // 
            colAlarmTime.DataPropertyName = "AlarmTime";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss";
            colAlarmTime.DefaultCellStyle = dataGridViewCellStyle2;
            colAlarmTime.FillWeight = 150F;
            colAlarmTime.HeaderText = "报警时间";
            colAlarmTime.MinimumWidth = 6;
            colAlarmTime.Name = "colAlarmTime";
            colAlarmTime.ReadOnly = true;
            // 
            // colInfoName
            // 
            colInfoName.DataPropertyName = "InfoTypeName";
            colInfoName.HeaderText = "报警来源";
            colInfoName.MinimumWidth = 6;
            colInfoName.Name = "colInfoName";
            colInfoName.ReadOnly = true;
            // 
            // colAlarmType
            // 
            colAlarmType.DataPropertyName = "AlarmTypeName";
            colAlarmType.HeaderText = "报警类型";
            colAlarmType.MinimumWidth = 6;
            colAlarmType.Name = "colAlarmType";
            colAlarmType.ReadOnly = true;
            // 
            // colAlarmState
            // 
            colAlarmState.DataPropertyName = "AlarmStateName";
            colAlarmState.HeaderText = "报警状态";
            colAlarmState.MinimumWidth = 6;
            colAlarmState.Name = "colAlarmState";
            colAlarmState.ReadOnly = true;
            // 
            // colAlarmValue
            // 
            colAlarmValue.DataPropertyName = "AlarmValue";
            colAlarmValue.FillWeight = 60F;
            colAlarmValue.HeaderText = "报警值";
            colAlarmValue.MinimumWidth = 6;
            colAlarmValue.Name = "colAlarmValue";
            colAlarmValue.ReadOnly = true;
            // 
            // colAlarmNote
            // 
            colAlarmNote.DataPropertyName = "AlarmNote";
            colAlarmNote.FillWeight = 200F;
            colAlarmNote.HeaderText = "报警描述";
            colAlarmNote.MinimumWidth = 6;
            colAlarmNote.Name = "colAlarmNote";
            colAlarmNote.ReadOnly = true;
            // 
            // lblDelMsg
            // 
            lblDelMsg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDelMsg.BackColor = Color.Transparent;
            lblDelMsg.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblDelMsg.ForeColor = Color.Red;
            lblDelMsg.Location = new Point(629, 205);
            lblDelMsg.Margin = new Padding(4, 0, 4, 0);
            lblDelMsg.Name = "lblDelMsg";
            lblDelMsg.Size = new Size(726, 42);
            lblDelMsg.TabIndex = 15;
            lblDelMsg.Text = "请选择要删除的参数信息！";
            lblDelMsg.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            btnDelete.Location = new Point(1478, 206);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 42);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "删除记录";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // pager
            // 
            pager.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pager.BackColor = Color.Transparent;
            pager.ForeColor = Color.Silver;
            pager.Location = new Point(27, 925);
            pager.Margin = new Padding(4);
            pager.Name = "pager";
            pager.PageSize = 15;
            pager.Size = new Size(1592, 62);
            pager.TabIndex = 14;
            pager.PageChanged += pager_PageChanged;
            // 
            // FrmAlarmManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1628, 1000);
            Controls.Add(pager);
            Controls.Add(btnDelete);
            Controls.Add(lblDelMsg);
            Controls.Add(dgvAlarmLogList);
            Controls.Add(uLine6);
            Controls.Add(label1);
            Controls.Add(uGroupPanel21);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmAlarmManage";
            Text = "FrmAlarmManage";
            Load += FrmAlarmManage_Load;
            uGroupPanel21.ResumeLayout(false);
            uGroupPanel21.PerformLayout();
            panelAlarmStates.ResumeLayout(false);
            panelAlarmStates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlarmLogList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel2 uGroupPanel21;
        private Label label1;
        private Zhaoxi.CustControls.ULine uLine6;
        private DataGridView dgvAlarmLogList;
        private RadioButton rbtnRealTimeAlarm;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private RadioButton rbtnHistoryAlarm;
        private Panel panelAlarmStates;
        private CheckBox checkBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private DateTimePicker dtStartTime;
        private ComboBox cboInfoTypes;
        private DateTimePicker dtEndTime;
        private Label label6;
        private Zhaoxi.CustControls.UButton btnFind;
        private Label lblDelMsg;
        private Zhaoxi.CustControls.UButton btnDelete;
        private Zhaoxi.CustControls.UPager pager;
        private DataGridViewCheckBoxColumn colChk;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colAlarmTime;
        private DataGridViewTextBoxColumn colInfoName;
        private DataGridViewTextBoxColumn colAlarmType;
        private DataGridViewTextBoxColumn colAlarmState;
        private DataGridViewTextBoxColumn colAlarmValue;
        private DataGridViewTextBoxColumn colAlarmNote;
    }
}