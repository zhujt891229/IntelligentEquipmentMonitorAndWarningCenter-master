namespace IntelligentEquipmentMonitorAndWarningCenter.SysConfigs
{
    partial class FrmCommunicateConfig
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboBaudRate = new ComboBox();
            cboParity = new ComboBox();
            btnOK = new Zhaoxi.CustControls.UButton();
            lblMsg = new Label();
            uGroupPanel31 = new Zhaoxi.CustControls.UGroupPanel3();
            panel2 = new Panel();
            rbtnStopBits_2 = new RadioButton();
            rbtnStopBits_1 = new RadioButton();
            panel1 = new Panel();
            rbtnBits_8 = new RadioButton();
            rbtnBits_7 = new RadioButton();
            uGroupPanel31.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(287, 88);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 1;
            label1.Text = "波特率：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(287, 155);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "校验位：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(287, 225);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 6;
            label3.Text = "数据位：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(287, 291);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 8;
            label4.Text = "停止位：";
            // 
            // cboBaudRate
            // 
            cboBaudRate.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboBaudRate.FormattingEnabled = true;
            cboBaudRate.Location = new Point(391, 88);
            cboBaudRate.Name = "cboBaudRate";
            cboBaudRate.Size = new Size(151, 32);
            cboBaudRate.TabIndex = 13;
            // 
            // cboParity
            // 
            cboParity.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboParity.FormattingEnabled = true;
            cboParity.Location = new Point(391, 155);
            cboParity.Name = "cboParity";
            cboParity.Size = new Size(151, 32);
            cboParity.TabIndex = 14;
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
            btnOK.Location = new Point(391, 373);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(92, 39);
            btnOK.TabIndex = 15;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.FromArgb(25, 55, 87);
            lblMsg.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Orange;
            lblMsg.Location = new Point(391, 452);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(325, 105);
            lblMsg.TabIndex = 16;
            lblMsg.Text = "设置成功";
            // 
            // uGroupPanel31
            // 
            uGroupPanel31.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel31.Background = Color.Black;
            uGroupPanel31.Controls.Add(panel2);
            uGroupPanel31.Controls.Add(panel1);
            uGroupPanel31.Controls.Add(lblMsg);
            uGroupPanel31.Controls.Add(btnOK);
            uGroupPanel31.Controls.Add(cboParity);
            uGroupPanel31.Controls.Add(cboBaudRate);
            uGroupPanel31.Controls.Add(label4);
            uGroupPanel31.Controls.Add(label3);
            uGroupPanel31.Controls.Add(label2);
            uGroupPanel31.Controls.Add(label1);
            uGroupPanel31.CornerRadius = 5;
            uGroupPanel31.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel31.ForeColor = Color.White;
            uGroupPanel31.Location = new Point(30, 12);
            uGroupPanel31.Name = "uGroupPanel31";
            uGroupPanel31.PrimaryColor = Color.White;
            uGroupPanel31.Size = new Size(1112, 545);
            uGroupPanel31.TabIndex = 1;
            uGroupPanel31.TabStop = false;
            uGroupPanel31.Text = "通信连接配置";
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtnStopBits_2);
            panel2.Controls.Add(rbtnStopBits_1);
            panel2.Location = new Point(391, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 41);
            panel2.TabIndex = 18;
            // 
            // rbtnStopBits_2
            // 
            rbtnStopBits_2.AutoSize = true;
            rbtnStopBits_2.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnStopBits_2.Location = new Point(95, 3);
            rbtnStopBits_2.Name = "rbtnStopBits_2";
            rbtnStopBits_2.Size = new Size(80, 31);
            rbtnStopBits_2.TabIndex = 1;
            rbtnStopBits_2.TabStop = true;
            rbtnStopBits_2.Text = "Two";
            rbtnStopBits_2.UseVisualStyleBackColor = true;
            // 
            // rbtnStopBits_1
            // 
            rbtnStopBits_1.AutoSize = true;
            rbtnStopBits_1.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnStopBits_1.Location = new Point(3, 5);
            rbtnStopBits_1.Name = "rbtnStopBits_1";
            rbtnStopBits_1.Size = new Size(78, 31);
            rbtnStopBits_1.TabIndex = 0;
            rbtnStopBits_1.TabStop = true;
            rbtnStopBits_1.Text = "One";
            rbtnStopBits_1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnBits_8);
            panel1.Controls.Add(rbtnBits_7);
            panel1.Location = new Point(391, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 41);
            panel1.TabIndex = 17;
            // 
            // rbtnBits_8
            // 
            rbtnBits_8.AutoSize = true;
            rbtnBits_8.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnBits_8.Location = new Point(95, 5);
            rbtnBits_8.Name = "rbtnBits_8";
            rbtnBits_8.Size = new Size(69, 31);
            rbtnBits_8.TabIndex = 1;
            rbtnBits_8.TabStop = true;
            rbtnBits_8.Text = "8位";
            rbtnBits_8.UseVisualStyleBackColor = true;
            // 
            // rbtnBits_7
            // 
            rbtnBits_7.AutoSize = true;
            rbtnBits_7.Font = new Font("微软雅黑", 10F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnBits_7.Location = new Point(3, 5);
            rbtnBits_7.Name = "rbtnBits_7";
            rbtnBits_7.Size = new Size(69, 31);
            rbtnBits_7.TabIndex = 0;
            rbtnBits_7.TabStop = true;
            rbtnBits_7.Text = "7位";
            rbtnBits_7.UseVisualStyleBackColor = true;
            // 
            // FrmCommunicateConfig
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1178, 607);
            Controls.Add(uGroupPanel31);
            Name = "FrmCommunicateConfig";
            Text = "通信连接配置";
            Load += FrmCommunicateConfig_Load;
            VisibleChanged += FrmCommunicateConfig_VisibleChanged;
            uGroupPanel31.ResumeLayout(false);
            uGroupPanel31.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboBaudRate;
        private ComboBox cboParity;
        private Zhaoxi.CustControls.UButton btnOK;
        private Label lblMsg;
        private Zhaoxi.CustControls.UGroupPanel3 uGroupPanel31;
        private Panel panel2;
        private RadioButton rbtnStopBits_2;
        private RadioButton rbtnStopBits_1;
        private Panel panel1;
        private RadioButton rbtnBits_8;
        private RadioButton rbtnBits_7;
    }
}