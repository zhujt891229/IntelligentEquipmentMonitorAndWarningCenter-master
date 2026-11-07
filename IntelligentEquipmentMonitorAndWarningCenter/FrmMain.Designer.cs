namespace IntelligentEquipmentMonitorAndWarningCenter
{
    partial class FrmMain
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
            uFormHeader1 = new Zhaoxi.CustControls.UFormHeader();
            panelPage = new Panel();
            tableNavBar = new TableLayoutPanel();
            panel3 = new Panel();
            label4 = new Label();
            lblLoginUser = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblConnectState = new Label();
            label1 = new Label();
            navSystem = new IntelligentEquipmentMonitorAndWarningCenter.UControls.UNavItem();
            navDeviceMonitor = new IntelligentEquipmentMonitorAndWarningCenter.UControls.UNavItem();
            navAlarmManger = new IntelligentEquipmentMonitorAndWarningCenter.UControls.UNavItem();
            navLiveTrends = new IntelligentEquipmentMonitorAndWarningCenter.UControls.UNavItem();
            navReportManger = new IntelligentEquipmentMonitorAndWarningCenter.UControls.UNavItem();
            tableNavBar.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // uFormHeader1
            // 
            uFormHeader1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uFormHeader1.Background = Color.FromArgb(0, 0, 64);
            uFormHeader1.BorderColor = Color.FromArgb(0, 189, 206);
            uFormHeader1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uFormHeader1.Header = "智能设备检测预警";
            uFormHeader1.Location = new Point(1, 1);
            uFormHeader1.Margin = new Padding(2, 2, 2, 2);
            uFormHeader1.Name = "uFormHeader1";
            uFormHeader1.SecondaryColor = Color.Aqua;
            uFormHeader1.Size = new Size(1041, 62);
            uFormHeader1.TabIndex = 0;
            uFormHeader1.Text = "uFormHeader1";
            // 
            // panelPage
            // 
            panelPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPage.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panelPage.ForeColor = Color.LightGray;
            panelPage.Location = new Point(4, 67);
            panelPage.Margin = new Padding(2, 2, 2, 2);
            panelPage.Name = "panelPage";
            panelPage.Size = new Size(1039, 551);
            panelPage.TabIndex = 1;
            panelPage.SizeChanged += panelPage_SizeChanged;
            // 
            // tableNavBar
            // 
            tableNavBar.BackColor = Color.FromArgb(54, 98, 133);
            tableNavBar.ColumnCount = 7;
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tableNavBar.Controls.Add(panel3, 6, 0);
            tableNavBar.Controls.Add(panel1, 0, 0);
            tableNavBar.Controls.Add(navSystem, 1, 0);
            tableNavBar.Controls.Add(navDeviceMonitor, 2, 0);
            tableNavBar.Controls.Add(navAlarmManger, 3, 0);
            tableNavBar.Controls.Add(navLiveTrends, 4, 0);
            tableNavBar.Controls.Add(navReportManger, 5, 0);
            tableNavBar.Dock = DockStyle.Bottom;
            tableNavBar.Location = new Point(0, 622);
            tableNavBar.Margin = new Padding(2, 2, 2, 2);
            tableNavBar.Name = "tableNavBar";
            tableNavBar.RowCount = 1;
            tableNavBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableNavBar.Size = new Size(1047, 51);
            tableNavBar.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblLoginUser);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(899, 2);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 47);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(11, 14);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 0;
            label4.Text = "用户：";
            // 
            // lblLoginUser
            // 
            lblLoginUser.BackColor = Color.Transparent;
            lblLoginUser.ForeColor = Color.Goldenrod;
            lblLoginUser.Location = new Point(50, 6);
            lblLoginUser.Margin = new Padding(2, 0, 2, 0);
            lblLoginUser.Name = "lblLoginUser";
            lblLoginUser.Size = new Size(89, 34);
            lblLoginUser.TabIndex = 1;
            lblLoginUser.Text = "admin";
            lblLoginUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(163, 47);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblConnectState);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(163, 47);
            panel2.TabIndex = 2;
            // 
            // lblConnectState
            // 
            lblConnectState.BackColor = Color.Transparent;
            lblConnectState.ForeColor = Color.DeepSkyBlue;
            lblConnectState.Location = new Point(50, 6);
            lblConnectState.Margin = new Padding(2, 0, 2, 0);
            lblConnectState.Name = "lblConnectState";
            lblConnectState.Size = new Size(89, 34);
            lblConnectState.TabIndex = 1;
            lblConnectState.Text = "未连接";
            lblConnectState.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(6, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "状态：";
            // 
            // navSystem
            // 
            navSystem.BgColor = Color.FromArgb(54, 98, 133);
            navSystem.Dock = DockStyle.Fill;
            navSystem.HeadColor = Color.White;
            navSystem.Header = "系统配置";
            navSystem.HeaderFont = new Font("Microsoft YaHei UI", 9F);
            navSystem.Icon = Properties.Resources.xitongpeizhi;
            navSystem.Location = new Point(169, 2);
            navSystem.Margin = new Padding(2, 2, 2, 2);
            navSystem.Name = "navSystem";
            navSystem.SelIcon = Properties.Resources.xitongpeizhi1;
            navSystem.Size = new Size(142, 47);
            navSystem.TabIndex = 2;
            navSystem.Tag = "systemconfig";
            // 
            // navDeviceMonitor
            // 
            navDeviceMonitor.BgColor = Color.FromArgb(54, 98, 133);
            navDeviceMonitor.Dock = DockStyle.Fill;
            navDeviceMonitor.HeadColor = Color.White;
            navDeviceMonitor.Header = "设备监控";
            navDeviceMonitor.HeaderFont = new Font("Microsoft YaHei UI", 9F);
            navDeviceMonitor.Icon = Properties.Resources.shebeijiance;
            navDeviceMonitor.Location = new Point(315, 2);
            navDeviceMonitor.Margin = new Padding(2, 2, 2, 2);
            navDeviceMonitor.Name = "navDeviceMonitor";
            navDeviceMonitor.SelIcon = Properties.Resources.shebeijiance1;
            navDeviceMonitor.Size = new Size(142, 47);
            navDeviceMonitor.TabIndex = 3;
            navDeviceMonitor.Tag = "devicemonitor";
            // 
            // navAlarmManger
            // 
            navAlarmManger.BackColor = Color.FromArgb(54, 98, 133);
            navAlarmManger.BgColor = Color.FromArgb(54, 98, 133);
            navAlarmManger.Dock = DockStyle.Fill;
            navAlarmManger.HeadColor = Color.White;
            navAlarmManger.Header = "预警管理";
            navAlarmManger.HeaderFont = new Font("Microsoft YaHei UI", 9F);
            navAlarmManger.Icon = Properties.Resources.yujingguanli;
            navAlarmManger.Location = new Point(461, 2);
            navAlarmManger.Margin = new Padding(2, 2, 2, 2);
            navAlarmManger.Name = "navAlarmManger";
            navAlarmManger.SelIcon = Properties.Resources.yujingguanli1;
            navAlarmManger.Size = new Size(142, 47);
            navAlarmManger.TabIndex = 4;
            navAlarmManger.Tag = "alarmmanger";
            // 
            // navLiveTrends
            // 
            navLiveTrends.BgColor = Color.FromArgb(54, 98, 133);
            navLiveTrends.Dock = DockStyle.Fill;
            navLiveTrends.HeadColor = Color.White;
            navLiveTrends.Header = "实时曲线";
            navLiveTrends.HeaderFont = new Font("Microsoft YaHei UI", 9F);
            navLiveTrends.Icon = Properties.Resources.shishiquxian;
            navLiveTrends.Location = new Point(607, 2);
            navLiveTrends.Margin = new Padding(2, 2, 2, 2);
            navLiveTrends.Name = "navLiveTrends";
            navLiveTrends.SelIcon = null;
            navLiveTrends.Size = new Size(142, 47);
            navLiveTrends.TabIndex = 5;
            navLiveTrends.Tag = "livetrends";
            // 
            // navReportManger
            // 
            navReportManger.BgColor = Color.FromArgb(54, 98, 133);
            navReportManger.Dock = DockStyle.Fill;
            navReportManger.HeadColor = Color.White;
            navReportManger.Header = "报表统计";
            navReportManger.HeaderFont = new Font("Microsoft YaHei UI", 9F);
            navReportManger.Icon = Properties.Resources.tongjibaobiao;
            navReportManger.Location = new Point(753, 2);
            navReportManger.Margin = new Padding(2, 2, 2, 2);
            navReportManger.Name = "navReportManger";
            navReportManger.SelIcon = Properties.Resources.tongjibaobiao1;
            navReportManger.Size = new Size(142, 47);
            navReportManger.TabIndex = 6;
            navReportManger.Tag = "reports";
            navReportManger.Load += navReportManger_Load;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1047, 673);
            Controls.Add(tableNavBar);
            Controls.Add(panelPage);
            Controls.Add(uFormHeader1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "FrmMain";
            Text = "FrmMain";
            FormClosing += FrmMain_FormClosing;
            tableNavBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Zhaoxi.CustControls.UFormHeader uFormHeader1;
        private Panel panelPage;
        private TableLayoutPanel tableNavBar;
        private Panel panel1;
        private Label label1;
        private Label lblConnectState;
        private Panel panel3;
        private Label label4;
        private Label lblLoginUser;
        private Panel panel2;
        private UControls.UNavItem navSystem;
        private UControls.UNavItem navDeviceMonitor;
        private UControls.UNavItem navAlarmManger;
        private UControls.UNavItem navLiveTrends;
        private UControls.UNavItem navReportManger;
    }
}