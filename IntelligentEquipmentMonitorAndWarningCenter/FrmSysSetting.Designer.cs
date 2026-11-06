namespace IntelligentEquipmentMonitorAndWarningCenter
{
    partial class FrmSysSetting
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
            uLine1 = new Zhaoxi.CustControls.ULine();
            chkEnableSetting = new CheckBox();
            btnStore = new Zhaoxi.CustControls.UButton();
            btnCommunicate = new Zhaoxi.CustControls.UButton();
            btnPara = new Zhaoxi.CustControls.UButton();
            btnAlarm = new Zhaoxi.CustControls.UButton();
            panelChild = new Panel();
            SuspendLayout();
            // 
            // uLine1
            // 
            uLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine1.ForeColor = Color.Gainsboro;
            uLine1.LineColor = Color.LightSlateGray;
            uLine1.Location = new Point(27, 87);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(1328, 10);
            uLine1.TabIndex = 0;
            uLine1.Text = "uLine1";
            // 
            // chkEnableSetting
            // 
            chkEnableSetting.AutoSize = true;
            chkEnableSetting.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chkEnableSetting.ForeColor = Color.Gainsboro;
            chkEnableSetting.Location = new Point(45, 37);
            chkEnableSetting.Name = "chkEnableSetting";
            chkEnableSetting.Size = new Size(122, 32);
            chkEnableSetting.TabIndex = 1;
            chkEnableSetting.Text = "启用设置";
            chkEnableSetting.UseVisualStyleBackColor = true;
            chkEnableSetting.Click += chkEnableSetting_Click;
            // 
            // btnStore
            // 
            btnStore.BgColor = Color.SlateGray;
            btnStore.BgColor2 = Color.LightSteelBlue;
            btnStore.FlatAppearance.BorderSize = 0;
            btnStore.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStore.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStore.FlatStyle = FlatStyle.Flat;
            btnStore.FocusBgColor = Color.FromArgb(58, 104, 141);
            btnStore.FocusForeColor = Color.SkyBlue;
            btnStore.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnStore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btnStore.Location = new Point(213, 27);
            btnStore.Name = "btnStore";
            btnStore.Size = new Size(145, 53);
            btnStore.TabIndex = 2;
            btnStore.Text = "存储配置";
            btnStore.UseVisualStyleBackColor = true;
            // 
            // btnCommunicate
            // 
            btnCommunicate.BgColor = Color.SlateGray;
            btnCommunicate.BgColor2 = Color.LightSteelBlue;
            btnCommunicate.FlatAppearance.BorderSize = 0;
            btnCommunicate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCommunicate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCommunicate.FlatStyle = FlatStyle.Flat;
            btnCommunicate.FocusBgColor = Color.FromArgb(58, 104, 141);
            btnCommunicate.FocusForeColor = Color.SkyBlue;
            btnCommunicate.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnCommunicate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btnCommunicate.Location = new Point(445, 28);
            btnCommunicate.Name = "btnCommunicate";
            btnCommunicate.Size = new Size(145, 53);
            btnCommunicate.TabIndex = 3;
            btnCommunicate.Text = "通信配置";
            btnCommunicate.UseVisualStyleBackColor = true;
            btnCommunicate.Click += BtnCommunicate_Click;
            // 
            // btnPara
            // 
            btnPara.BgColor = Color.SlateGray;
            btnPara.BgColor2 = Color.LightSteelBlue;
            btnPara.FlatAppearance.BorderSize = 0;
            btnPara.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPara.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPara.FlatStyle = FlatStyle.Flat;
            btnPara.FocusBgColor = Color.FromArgb(58, 104, 141);
            btnPara.FocusForeColor = Color.SkyBlue;
            btnPara.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnPara.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btnPara.Location = new Point(678, 28);
            btnPara.Name = "btnPara";
            btnPara.Size = new Size(145, 53);
            btnPara.TabIndex = 4;
            btnPara.Text = "参数配置";
            btnPara.UseVisualStyleBackColor = true;
            btnPara.Click += BtnPara_Click;
            // 
            // btnAlarm
            // 
            btnAlarm.BgColor = Color.SlateGray;
            btnAlarm.BgColor2 = Color.LightSteelBlue;
            btnAlarm.FlatAppearance.BorderSize = 0;
            btnAlarm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAlarm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAlarm.FlatStyle = FlatStyle.Flat;
            btnAlarm.FocusBgColor = Color.FromArgb(58, 104, 141);
            btnAlarm.FocusForeColor = Color.SkyBlue;
            btnAlarm.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnAlarm.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btnAlarm.Location = new Point(920, 27);
            btnAlarm.Name = "btnAlarm";
            btnAlarm.Size = new Size(145, 53);
            btnAlarm.TabIndex = 5;
            btnAlarm.Text = "预警配置";
            btnAlarm.UseVisualStyleBackColor = true;
            btnAlarm.Click += BtnAlarm_Click;
            // 
            // panelChild
            // 
            panelChild.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelChild.Location = new Point(27, 125);
            panelChild.Name = "panelChild";
            panelChild.Size = new Size(1318, 588);
            panelChild.TabIndex = 6;
            panelChild.SizeChanged += panelChild_SizeChanged;
            // 
            // FrmSysSetting
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1373, 738);
            Controls.Add(panelChild);
            Controls.Add(btnAlarm);
            Controls.Add(btnPara);
            Controls.Add(btnCommunicate);
            Controls.Add(btnStore);
            Controls.Add(chkEnableSetting);
            Controls.Add(uLine1);
            ForeColor = Color.AliceBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmSysSetting";
            Text = "FrmSysSetting";
            Load += FrmSysSetting_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zhaoxi.CustControls.ULine uLine1;
        private CheckBox chkEnableSetting;
        private Zhaoxi.CustControls.UButton btnStore;
        private Zhaoxi.CustControls.UButton btnCommunicate;
        private Zhaoxi.CustControls.UButton btnPara;
        private Zhaoxi.CustControls.UButton btnAlarm;
        private Panel panelChild;
    }
}