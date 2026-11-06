namespace IntelligentEquipmentMonitorAndWarningCenter.SysConfigs
{
    partial class FrmStoreConfig
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
            uGroupPanel31 = new Zhaoxi.CustControls.UGroupPanel3();
            lblMsg = new Label();
            btnOK = new Zhaoxi.CustControls.UButton();
            cboAlarmFileTypes = new ComboBox();
            cboComFileTypes = new ComboBox();
            cboDbTypes = new ComboBox();
            label5 = new Label();
            txtAlarmFileName = new TextBox();
            label4 = new Label();
            txtCommunicationFileName = new TextBox();
            label3 = new Label();
            txtDbaseFileName = new TextBox();
            label2 = new Label();
            btnChoose = new Zhaoxi.CustControls.UButton();
            txtStorePath = new TextBox();
            label1 = new Label();
            uGroupPanel31.SuspendLayout();
            SuspendLayout();
            // 
            // uGroupPanel31
            // 
            uGroupPanel31.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel31.Background = Color.Black;
            uGroupPanel31.Controls.Add(lblMsg);
            uGroupPanel31.Controls.Add(btnOK);
            uGroupPanel31.Controls.Add(cboAlarmFileTypes);
            uGroupPanel31.Controls.Add(cboComFileTypes);
            uGroupPanel31.Controls.Add(cboDbTypes);
            uGroupPanel31.Controls.Add(label5);
            uGroupPanel31.Controls.Add(txtAlarmFileName);
            uGroupPanel31.Controls.Add(label4);
            uGroupPanel31.Controls.Add(txtCommunicationFileName);
            uGroupPanel31.Controls.Add(label3);
            uGroupPanel31.Controls.Add(txtDbaseFileName);
            uGroupPanel31.Controls.Add(label2);
            uGroupPanel31.Controls.Add(btnChoose);
            uGroupPanel31.Controls.Add(txtStorePath);
            uGroupPanel31.Controls.Add(label1);
            uGroupPanel31.CornerRadius = 5;
            uGroupPanel31.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel31.ForeColor = Color.White;
            uGroupPanel31.Location = new Point(12, 12);
            uGroupPanel31.Name = "uGroupPanel31";
            uGroupPanel31.PrimaryColor = Color.White;
            uGroupPanel31.Size = new Size(1219, 597);
            uGroupPanel31.TabIndex = 0;
            uGroupPanel31.TabStop = false;
            uGroupPanel31.Text = "数据存储配置";
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.FromArgb(25, 55, 87);
            lblMsg.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Orange;
            lblMsg.Location = new Point(327, 460);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(325, 105);
            lblMsg.TabIndex = 16;
            lblMsg.Text = "设置成功";
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
            btnOK.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(328, 391);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(80, 30);
            btnOK.TabIndex = 15;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // cboAlarmFileTypes
            // 
            cboAlarmFileTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboAlarmFileTypes.FormattingEnabled = true;
            cboAlarmFileTypes.Items.AddRange(new object[] { ".txt", ".xml", ".json" });
            cboAlarmFileTypes.Location = new Point(783, 291);
            cboAlarmFileTypes.Name = "cboAlarmFileTypes";
            cboAlarmFileTypes.Size = new Size(123, 32);
            cboAlarmFileTypes.TabIndex = 14;
            cboAlarmFileTypes.SelectedIndexChanged += cboAlarmFileTypes_SelectedIndexChanged;
            // 
            // cboComFileTypes
            // 
            cboComFileTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboComFileTypes.FormattingEnabled = true;
            cboComFileTypes.Items.AddRange(new object[] { ".txt", ".xml" });
            cboComFileTypes.Location = new Point(783, 222);
            cboComFileTypes.Name = "cboComFileTypes";
            cboComFileTypes.Size = new Size(123, 32);
            cboComFileTypes.TabIndex = 13;
            cboComFileTypes.SelectedIndexChanged += cboComFileTypes_SelectedIndexChanged;
            // 
            // cboDbTypes
            // 
            cboDbTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboDbTypes.FormattingEnabled = true;
            cboDbTypes.Items.AddRange(new object[] { ".db", ".sqlite" });
            cboDbTypes.Location = new Point(783, 148);
            cboDbTypes.Name = "cboDbTypes";
            cboDbTypes.Size = new Size(123, 32);
            cboDbTypes.TabIndex = 12;
            cboDbTypes.SelectedIndexChanged += cboDbTypes_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(688, 149);
            label5.Name = "label5";
            label5.Size = new Size(89, 25);
            label5.TabIndex = 10;
            label5.Text = "文件类型:";
            // 
            // txtAlarmFileName
            // 
            txtAlarmFileName.Location = new Point(301, 291);
            txtAlarmFileName.Name = "txtAlarmFileName";
            txtAlarmFileName.Size = new Size(351, 30);
            txtAlarmFileName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(150, 291);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 8;
            label4.Text = "预警配置文件:";
            // 
            // txtCommunicationFileName
            // 
            txtCommunicationFileName.Location = new Point(301, 222);
            txtCommunicationFileName.Name = "txtCommunicationFileName";
            txtCommunicationFileName.Size = new Size(351, 30);
            txtCommunicationFileName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(139, 222);
            label3.Name = "label3";
            label3.Size = new Size(156, 25);
            label3.TabIndex = 6;
            label3.Text = "通信配置文件名：";
            // 
            // txtDbaseFileName
            // 
            txtDbaseFileName.Location = new Point(301, 148);
            txtDbaseFileName.Name = "txtDbaseFileName";
            txtDbaseFileName.Size = new Size(351, 30);
            txtDbaseFileName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(160, 153);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 4;
            label2.Text = "数据库文件名:";
            // 
            // btnChoose
            // 
            btnChoose.BgColor = Color.DeepSkyBlue;
            btnChoose.BgColor2 = Color.LightBlue;
            btnChoose.BorderColor = Color.FromArgb(25, 55, 87);
            btnChoose.BorderWidth = 1;
            btnChoose.FlatAppearance.BorderSize = 0;
            btnChoose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnChoose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnChoose.FlatStyle = FlatStyle.Flat;
            btnChoose.FocusBgColor = Color.FromArgb(54, 98, 133);
            btnChoose.FocusForeColor = Color.Orange;
            btnChoose.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(1066, 83);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(80, 30);
            btnChoose.TabIndex = 3;
            btnChoose.Text = "选择....";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // txtStorePath
            // 
            txtStorePath.Location = new Point(301, 83);
            txtStorePath.Name = "txtStorePath";
            txtStorePath.Size = new Size(734, 30);
            txtStorePath.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(98, 84);
            label1.Name = "label1";
            label1.Size = new Size(197, 25);
            label1.TabIndex = 1;
            label1.Text = "数据文件存储路径配置:";
            // 
            // FrmStoreConfig
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1243, 611);
            Controls.Add(uGroupPanel31);
            Name = "FrmStoreConfig";
            Text = "数据存储配置";
            Load += FrmStoreConfig_Load;
            VisibleChanged += FrmStoreConfig_VisibleChanged;
            uGroupPanel31.ResumeLayout(false);
            uGroupPanel31.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel3 uGroupPanel31;
        private Label label1;
        private TextBox txtStorePath;
        private Zhaoxi.CustControls.UButton btnChoose;
        private ComboBox cboDbTypes;
        private Label label5;
        private TextBox txtAlarmFileName;
        private Label label4;
        private TextBox txtCommunicationFileName;
        private Label label3;
        private TextBox txtDbaseFileName;
        private Label label2;
        private Zhaoxi.CustControls.UButton btnOK;
        private ComboBox cboAlarmFileTypes;
        private ComboBox cboComFileTypes;
        private Label lblMsg;
    }
}