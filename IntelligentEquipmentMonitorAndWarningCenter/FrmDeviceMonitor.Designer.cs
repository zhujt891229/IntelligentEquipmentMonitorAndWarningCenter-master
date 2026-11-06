using NPOI.Util.Collections;

namespace IntelligentDeviceMonitorAndWarningCenter
{
    partial class FrmDeviceMonitor
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
            uGroupPanel11 = new Zhaoxi.CustControls.UGroupPanel1();
            btnConnect = new Zhaoxi.CustControls.UButton();
            btnRefreshPorts = new Zhaoxi.CustControls.UButton();
            cboPorts = new ComboBox();
            label2 = new Label();
            uLine1 = new Zhaoxi.CustControls.ULine();
            uGroupPanel12 = new Zhaoxi.CustControls.UGroupPanel1();
            jswLight05 = new Zhaoxi.CustControls.UJogSwitch();
            jswLight04 = new Zhaoxi.CustControls.UJogSwitch();
            jswLight03 = new Zhaoxi.CustControls.UJogSwitch();
            jswLight02 = new Zhaoxi.CustControls.UJogSwitch();
            jswLight01 = new Zhaoxi.CustControls.UJogSwitch();
            switchAll = new Zhaoxi.CustControls.USwitch();
            uLine2 = new Zhaoxi.CustControls.ULine();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            uGroupPanel13 = new Zhaoxi.CustControls.UGroupPanel1();
            numAlarms_B = new Zhaoxi.CustControls.UNumericBox();
            numAlarms_H = new Zhaoxi.CustControls.UNumericBox();
            numAlarms_T = new Zhaoxi.CustControls.UNumericBox();
            numAllAlarms = new Zhaoxi.CustControls.UNumericBox();
            uLine3 = new Zhaoxi.CustControls.ULine();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            uGroupPanel14 = new Zhaoxi.CustControls.UGroupPanel1();
            meter_B = new Zhaoxi.CustControls.UMeter();
            meter_H = new Zhaoxi.CustControls.UMeter();
            meter_T = new Zhaoxi.CustControls.UMeter();
            uLine4 = new Zhaoxi.CustControls.ULine();
            tableLayoutPanel1 = new TableLayoutPanel();
            uPanel6 = new Zhaoxi.CustControls.UPanel();
            lblHistoryL_B = new Zhaoxi.CustControls.ParaTextBox();
            lblHistoryH_B = new Zhaoxi.CustControls.ParaTextBox();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            uPanel5 = new Zhaoxi.CustControls.UPanel();
            lblHistoryL_H = new Zhaoxi.CustControls.ParaTextBox();
            lblHistoryH_H = new Zhaoxi.CustControls.ParaTextBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            uPanel4 = new Zhaoxi.CustControls.UPanel();
            lblHistoryL_T = new Zhaoxi.CustControls.ParaTextBox();
            lblHistoryH_T = new Zhaoxi.CustControls.ParaTextBox();
            label21 = new Label();
            label19 = new Label();
            label20 = new Label();
            uPanel3 = new Zhaoxi.CustControls.UPanel();
            lblValue_B = new Zhaoxi.CustControls.ParaTextBox();
            label17 = new Label();
            label18 = new Label();
            pbAlarm_B = new PictureBox();
            pictureBox6 = new PictureBox();
            uPanel2 = new Zhaoxi.CustControls.UPanel();
            lblValue_H = new Zhaoxi.CustControls.ParaTextBox();
            label15 = new Label();
            label16 = new Label();
            pbAlarm_H = new PictureBox();
            pictureBox4 = new PictureBox();
            uLine5 = new Zhaoxi.CustControls.ULine();
            uPanel1 = new Zhaoxi.CustControls.UPanel();
            lblValue_T = new Zhaoxi.CustControls.ParaTextBox();
            label14 = new Label();
            label13 = new Label();
            pbAlarm_T = new PictureBox();
            pictureBox1 = new PictureBox();
            uLine6 = new Zhaoxi.CustControls.ULine();
            dgvDataList = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCurTime = new DataGridViewTextBoxColumn();
            colTemperature = new DataGridViewTextBoxColumn();
            colHumidity = new DataGridViewTextBoxColumn();
            colBrightness = new DataGridViewTextBoxColumn();
            label1 = new Label();
            uGroupPanel11.SuspendLayout();
            uGroupPanel12.SuspendLayout();
            uGroupPanel13.SuspendLayout();
            uGroupPanel14.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            uPanel6.SuspendLayout();
            uPanel5.SuspendLayout();
            uPanel4.SuspendLayout();
            uPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            uPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            uPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_T).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataList).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel11
            // 
            uGroupPanel11.Background = Color.FromArgb(54, 98, 133);
            uGroupPanel11.Controls.Add(btnConnect);
            uGroupPanel11.Controls.Add(btnRefreshPorts);
            uGroupPanel11.Controls.Add(cboPorts);
            uGroupPanel11.Controls.Add(label2);
            uGroupPanel11.Controls.Add(uLine1);
            uGroupPanel11.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel11.Location = new Point(9, 11);
            uGroupPanel11.Margin = new Padding(4);
            uGroupPanel11.Name = "uGroupPanel11";
            uGroupPanel11.Padding = new Padding(4);
            uGroupPanel11.PrimaryColor = Color.SkyBlue;
            uGroupPanel11.Size = new Size(361, 252);
            uGroupPanel11.TabIndex = 0;
            uGroupPanel11.TabStop = false;
            uGroupPanel11.Text = "设备连接与断开";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Transparent;
            btnConnect.BgColor = Color.FromArgb(39, 139, 192);
            btnConnect.BgColor2 = Color.SteelBlue;
            btnConnect.BorderColor = Color.FromArgb(25, 55, 87);
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConnect.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.FocusBgColor = Color.Orange;
            btnConnect.FocusForeColor = Color.White;
            btnConnect.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(60, 174);
            btnConnect.Margin = new Padding(4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(257, 48);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "连接设备";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnRefreshPorts
            // 
            btnRefreshPorts.BackColor = Color.Transparent;
            btnRefreshPorts.BgColor = Color.DeepSkyBlue;
            btnRefreshPorts.BgColor2 = Color.LightBlue;
            btnRefreshPorts.BorderColor = Color.FromArgb(25, 55, 87);
            btnRefreshPorts.BorderWidth = 1;
            btnRefreshPorts.FlatAppearance.BorderSize = 0;
            btnRefreshPorts.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnRefreshPorts.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnRefreshPorts.FlatStyle = FlatStyle.Flat;
            btnRefreshPorts.FocusBgColor = Color.FromArgb(54, 98, 133);
            btnRefreshPorts.FocusForeColor = Color.White;
            btnRefreshPorts.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnRefreshPorts.ForeColor = Color.White;
            btnRefreshPorts.Location = new Point(238, 106);
            btnRefreshPorts.Margin = new Padding(4);
            btnRefreshPorts.Name = "btnRefreshPorts";
            btnRefreshPorts.Radius = 20;
            btnRefreshPorts.Size = new Size(84, 36);
            btnRefreshPorts.TabIndex = 3;
            btnRefreshPorts.Text = "刷新";
            btnRefreshPorts.UseVisualStyleBackColor = false;
            btnRefreshPorts.Click += btnRefreshPorts_Click;
            // 
            // cboPorts
            // 
            cboPorts.BackColor = Color.FromArgb(54, 98, 133);
            cboPorts.FlatStyle = FlatStyle.Flat;
            cboPorts.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboPorts.ForeColor = Color.White;
            cboPorts.FormattingEnabled = true;
            cboPorts.Location = new Point(60, 108);
            cboPorts.Margin = new Padding(4);
            cboPorts.Name = "cboPorts";
            cboPorts.Size = new Size(158, 32);
            cboPorts.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(27, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 1;
            label2.Text = "端口名：";
            // 
            // uLine1
            // 
            uLine1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine1.BackColor = Color.Transparent;
            uLine1.LineColor = Color.SlateGray;
            uLine1.Location = new Point(7, 36);
            uLine1.Margin = new Padding(4);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(342, 14);
            uLine1.TabIndex = 0;
            uLine1.Text = "uLine1";
            // 
            // uGroupPanel12
            // 
            uGroupPanel12.Background = Color.FromArgb(54, 98, 133);
            uGroupPanel12.Controls.Add(jswLight05);
            uGroupPanel12.Controls.Add(jswLight04);
            uGroupPanel12.Controls.Add(jswLight03);
            uGroupPanel12.Controls.Add(jswLight02);
            uGroupPanel12.Controls.Add(jswLight01);
            uGroupPanel12.Controls.Add(switchAll);
            uGroupPanel12.Controls.Add(uLine2);
            uGroupPanel12.Controls.Add(label8);
            uGroupPanel12.Controls.Add(label7);
            uGroupPanel12.Controls.Add(label6);
            uGroupPanel12.Controls.Add(label5);
            uGroupPanel12.Controls.Add(label4);
            uGroupPanel12.Controls.Add(label3);
            uGroupPanel12.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel12.Location = new Point(9, 274);
            uGroupPanel12.Margin = new Padding(4);
            uGroupPanel12.Name = "uGroupPanel12";
            uGroupPanel12.Padding = new Padding(4);
            uGroupPanel12.PrimaryColor = Color.SkyBlue;
            uGroupPanel12.Size = new Size(361, 366);
            uGroupPanel12.TabIndex = 0;
            uGroupPanel12.TabStop = false;
            uGroupPanel12.Text = "灯珠状态监控";
            // 
            // jswLight05
            // 
            jswLight05.BackColor = Color.Transparent;
            jswLight05.Location = new Point(138, 281);
            jswLight05.Margin = new Padding(4);
            jswLight05.Name = "jswLight05";
            jswLight05.OffColor = Color.LightSlateGray;
            jswLight05.OnColor = Color.FromArgb(48, 158, 211);
            jswLight05.Size = new Size(57, 57);
            jswLight05.TabIndex = 2;
            jswLight05.Text = "4";
            // 
            // jswLight04
            // 
            jswLight04.BackColor = Color.Transparent;
            jswLight04.Location = new Point(26, 281);
            jswLight04.Margin = new Padding(4);
            jswLight04.Name = "jswLight04";
            jswLight04.OffColor = Color.LightSlateGray;
            jswLight04.OnColor = Color.FromArgb(48, 158, 211);
            jswLight04.Size = new Size(57, 57);
            jswLight04.TabIndex = 2;
            jswLight04.Text = "3";
            // 
            // jswLight03
            // 
            jswLight03.BackColor = Color.Transparent;
            jswLight03.Location = new Point(247, 167);
            jswLight03.Margin = new Padding(4);
            jswLight03.Name = "jswLight03";
            jswLight03.OffColor = Color.LightSlateGray;
            jswLight03.OnColor = Color.FromArgb(48, 158, 211);
            jswLight03.Size = new Size(57, 57);
            jswLight03.TabIndex = 2;
            jswLight03.Text = "2";
            // 
            // jswLight02
            // 
            jswLight02.BackColor = Color.Transparent;
            jswLight02.IsOn = true;
            jswLight02.Location = new Point(138, 167);
            jswLight02.Margin = new Padding(4);
            jswLight02.Name = "jswLight02";
            jswLight02.OffColor = Color.LightSlateGray;
            jswLight02.OnColor = Color.FromArgb(48, 158, 211);
            jswLight02.Size = new Size(57, 57);
            jswLight02.TabIndex = 2;
            jswLight02.Text = "1";
            // 
            // jswLight01
            // 
            jswLight01.BackColor = Color.Transparent;
            jswLight01.Location = new Point(27, 167);
            jswLight01.Margin = new Padding(4);
            jswLight01.Name = "jswLight01";
            jswLight01.OffColor = Color.LightSlateGray;
            jswLight01.OnColor = Color.FromArgb(48, 158, 211);
            jswLight01.Size = new Size(57, 57);
            jswLight01.TabIndex = 2;
            jswLight01.Text = "0";
            // 
            // switchAll
            // 
            switchAll.BackColor = Color.Transparent;
            switchAll.Checked = true;
            switchAll.FalseColor = Color.FromArgb(111, 122, 126);
            switchAll.Location = new Point(145, 59);
            switchAll.Margin = new Padding(4, 5, 4, 5);
            switchAll.Name = "switchAll";
            switchAll.Size = new Size(171, 48);
            switchAll.SwitchType = Zhaoxi.CustControls.SwitchType.Line;
            switchAll.TabIndex = 1;
            switchAll.Texts = null;
            switchAll.TrueColor = Color.SkyBlue;
            switchAll.CheckedChanged += switchAll_CheckedChanged;
            // 
            // uLine2
            // 
            uLine2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine2.BackColor = Color.Transparent;
            uLine2.LineColor = Color.SlateGray;
            uLine2.Location = new Point(7, 36);
            uLine2.Margin = new Padding(4);
            uLine2.Name = "uLine2";
            uLine2.Size = new Size(342, 14);
            uLine2.TabIndex = 0;
            uLine2.Text = "uLine1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.FromArgb(174, 186, 189);
            label8.Location = new Point(145, 250);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 25);
            label8.TabIndex = 1;
            label8.Text = "5号灯";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label7.ForeColor = Color.FromArgb(174, 186, 189);
            label7.Location = new Point(26, 250);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 1;
            label7.Text = "4号灯";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.FromArgb(174, 186, 189);
            label6.Location = new Point(247, 132);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 1;
            label6.Text = "3号灯";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.FromArgb(174, 186, 189);
            label5.Location = new Point(143, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 1;
            label5.Text = "2号灯";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.FromArgb(174, 186, 189);
            label4.Location = new Point(26, 132);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 1;
            label4.Text = "1号灯";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.FromArgb(174, 186, 189);
            label3.Location = new Point(40, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 1;
            label3.Text = "全控开关";
            // 
            // uGroupPanel13
            // 
            uGroupPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            uGroupPanel13.Background = Color.FromArgb(54, 98, 133);
            uGroupPanel13.Controls.Add(numAlarms_B);
            uGroupPanel13.Controls.Add(numAlarms_H);
            uGroupPanel13.Controls.Add(numAlarms_T);
            uGroupPanel13.Controls.Add(numAllAlarms);
            uGroupPanel13.Controls.Add(uLine3);
            uGroupPanel13.Controls.Add(label12);
            uGroupPanel13.Controls.Add(label11);
            uGroupPanel13.Controls.Add(label10);
            uGroupPanel13.Controls.Add(label9);
            uGroupPanel13.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel13.Location = new Point(9, 652);
            uGroupPanel13.Margin = new Padding(4);
            uGroupPanel13.Name = "uGroupPanel13";
            uGroupPanel13.Padding = new Padding(4);
            uGroupPanel13.PrimaryColor = Color.SkyBlue;
            uGroupPanel13.Size = new Size(361, 294);
            uGroupPanel13.TabIndex = 0;
            uGroupPanel13.TabStop = false;
            uGroupPanel13.Text = "设备预警统计";
            // 
            // numAlarms_B
            // 
            numAlarms_B.BackColor = Color.Transparent;
            numAlarms_B.BgColor = Color.Transparent;
            numAlarms_B.BorderColor = Color.Black;
            numAlarms_B.BorderWidth = 0;
            numAlarms_B.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarms_B.ForeColor = Color.FromArgb(255, 128, 0);
            numAlarms_B.InnerPadding = new Padding(3);
            numAlarms_B.ItemBgColor = Color.FromArgb(54, 98, 133);
            numAlarms_B.ItemSpace = 2;
            numAlarms_B.Location = new Point(251, 200);
            numAlarms_B.Margin = new Padding(4);
            numAlarms_B.Name = "numAlarms_B";
            numAlarms_B.NumCount = 3;
            numAlarms_B.Size = new Size(104, 48);
            numAlarms_B.TabIndex = 1;
            numAlarms_B.Value = new decimal(new int[] { 36, 0, 0, 0 });
            // 
            // numAlarms_H
            // 
            numAlarms_H.BackColor = Color.Transparent;
            numAlarms_H.BgColor = Color.Transparent;
            numAlarms_H.BorderColor = Color.Black;
            numAlarms_H.BorderWidth = 0;
            numAlarms_H.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarms_H.ForeColor = Color.FromArgb(255, 128, 0);
            numAlarms_H.InnerPadding = new Padding(3);
            numAlarms_H.ItemBgColor = Color.FromArgb(54, 98, 133);
            numAlarms_H.ItemSpace = 2;
            numAlarms_H.Location = new Point(134, 200);
            numAlarms_H.Margin = new Padding(4);
            numAlarms_H.Name = "numAlarms_H";
            numAlarms_H.NumCount = 3;
            numAlarms_H.Size = new Size(104, 48);
            numAlarms_H.TabIndex = 1;
            numAlarms_H.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // numAlarms_T
            // 
            numAlarms_T.BackColor = Color.Transparent;
            numAlarms_T.BgColor = Color.Transparent;
            numAlarms_T.BorderColor = Color.Black;
            numAlarms_T.BorderWidth = 0;
            numAlarms_T.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarms_T.ForeColor = Color.FromArgb(255, 128, 0);
            numAlarms_T.InnerPadding = new Padding(3);
            numAlarms_T.ItemBgColor = Color.FromArgb(54, 98, 133);
            numAlarms_T.ItemSpace = 2;
            numAlarms_T.Location = new Point(17, 200);
            numAlarms_T.Margin = new Padding(4);
            numAlarms_T.Name = "numAlarms_T";
            numAlarms_T.NumCount = 3;
            numAlarms_T.Size = new Size(104, 48);
            numAlarms_T.TabIndex = 1;
            numAlarms_T.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numAllAlarms
            // 
            numAllAlarms.BackColor = Color.Transparent;
            numAllAlarms.BgColor = Color.Transparent;
            numAllAlarms.BorderColor = Color.Black;
            numAllAlarms.BorderWidth = 0;
            numAllAlarms.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAllAlarms.ForeColor = Color.FromArgb(255, 128, 0);
            numAllAlarms.InnerPadding = new Padding(3);
            numAllAlarms.ItemBgColor = Color.FromArgb(12, 36, 50);
            numAllAlarms.ItemSpace = 2;
            numAllAlarms.Location = new Point(156, 73);
            numAllAlarms.Margin = new Padding(4);
            numAllAlarms.Name = "numAllAlarms";
            numAllAlarms.NumCount = 4;
            numAllAlarms.Size = new Size(149, 55);
            numAllAlarms.TabIndex = 1;
            numAllAlarms.Value = new decimal(new int[] { 56, 0, 0, 0 });
            // 
            // uLine3
            // 
            uLine3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine3.BackColor = Color.Transparent;
            uLine3.LineColor = Color.SlateGray;
            uLine3.Location = new Point(7, 36);
            uLine3.Margin = new Padding(4);
            uLine3.Name = "uLine3";
            uLine3.Size = new Size(342, 14);
            uLine3.TabIndex = 0;
            uLine3.Text = "uLine1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label12.ForeColor = Color.FromArgb(174, 186, 189);
            label12.Location = new Point(260, 169);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(84, 25);
            label12.TabIndex = 1;
            label12.Text = "亮度预警";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.ForeColor = Color.FromArgb(174, 186, 189);
            label11.Location = new Point(144, 169);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 1;
            label11.Text = "湿度预警";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.ForeColor = Color.FromArgb(174, 186, 189);
            label10.Location = new Point(24, 169);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 25);
            label10.TabIndex = 1;
            label10.Text = "温度预警";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = Color.FromArgb(174, 186, 189);
            label9.Location = new Point(40, 86);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(101, 30);
            label9.TabIndex = 1;
            label9.Text = "预警总数";
            // 
            // uGroupPanel14
            // 
            uGroupPanel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            uGroupPanel14.Background = Color.FromArgb(54, 98, 133);
            uGroupPanel14.Controls.Add(meter_B);
            uGroupPanel14.Controls.Add(meter_H);
            uGroupPanel14.Controls.Add(meter_T);
            uGroupPanel14.Controls.Add(uLine4);
            uGroupPanel14.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel14.Location = new Point(1336, 11);
            uGroupPanel14.Margin = new Padding(4);
            uGroupPanel14.Name = "uGroupPanel14";
            uGroupPanel14.Padding = new Padding(4);
            uGroupPanel14.PrimaryColor = Color.SkyBlue;
            uGroupPanel14.Size = new Size(384, 935);
            uGroupPanel14.TabIndex = 0;
            uGroupPanel14.TabStop = false;
            uGroupPanel14.Text = "仪表呈现";
            // 
            // meter_B
            // 
            meter_B.BackColor = Color.Transparent;
            meter_B.Background = Color.FromArgb(10, 19, 24);
            meter_B.CenterElipseColor = Color.FromArgb(34, 51, 72);
            meter_B.DCount = 0;
            meter_B.Header = "Brightness";
            meter_B.HeaderColor = Color.FromArgb(224, 224, 224);
            meter_B.Location = new Point(46, 658);
            meter_B.Margin = new Padding(4);
            meter_B.Name = "meter_B";
            meter_B.PointColor = Color.SkyBlue;
            meter_B.ScaleLineColor = Color.Gainsboro;
            meter_B.ScaleValueColor = Color.WhiteSmoke;
            meter_B.Size = new Size(238, 238);
            meter_B.SurroundColor = Color.FromArgb(0, 33, 97, 216);
            meter_B.TabIndex = 1;
            meter_B.Text = "uMeter1";
            meter_B.Unit = "cd/m2";
            meter_B.UnitColor = Color.FromArgb(224, 224, 224);
            meter_B.Value = 75D;
            meter_B.ValueColor = Color.AliceBlue;
            // 
            // meter_H
            // 
            meter_H.BackColor = Color.Transparent;
            meter_H.Background = Color.FromArgb(10, 19, 24);
            meter_H.CenterElipseColor = Color.FromArgb(34, 51, 72);
            meter_H.DCount = 0;
            meter_H.Header = "Humidity";
            meter_H.HeaderColor = Color.FromArgb(224, 224, 224);
            meter_H.Location = new Point(46, 365);
            meter_H.Margin = new Padding(4);
            meter_H.Name = "meter_H";
            meter_H.PointColor = Color.SkyBlue;
            meter_H.ScaleLineColor = Color.Gainsboro;
            meter_H.ScaleValueColor = Color.WhiteSmoke;
            meter_H.Size = new Size(238, 238);
            meter_H.SurroundColor = Color.FromArgb(0, 33, 97, 216);
            meter_H.TabIndex = 1;
            meter_H.Text = "uMeter1";
            meter_H.Unit = "%";
            meter_H.UnitColor = Color.FromArgb(224, 224, 224);
            meter_H.Value = 55D;
            meter_H.ValueColor = Color.AliceBlue;
            // 
            // meter_T
            // 
            meter_T.BackColor = Color.Transparent;
            meter_T.Background = Color.FromArgb(10, 19, 24);
            meter_T.CenterElipseColor = Color.FromArgb(34, 51, 72);
            meter_T.Header = "Temperature";
            meter_T.HeaderColor = Color.FromArgb(224, 224, 224);
            meter_T.Location = new Point(46, 79);
            meter_T.Margin = new Padding(4);
            meter_T.MaxCount = 5;
            meter_T.MaxValue = 50D;
            meter_T.MinCount = 10;
            meter_T.Name = "meter_T";
            meter_T.PointColor = Color.SkyBlue;
            meter_T.ScaleLineColor = Color.Gainsboro;
            meter_T.ScaleValueColor = Color.WhiteSmoke;
            meter_T.Size = new Size(238, 238);
            meter_T.SurroundColor = Color.FromArgb(0, 33, 97, 216);
            meter_T.TabIndex = 1;
            meter_T.Text = "uMeter1";
            meter_T.Unit = "℃";
            meter_T.UnitColor = Color.FromArgb(224, 224, 224);
            meter_T.Value = 5D;
            meter_T.ValueColor = Color.AliceBlue;
            // 
            // uLine4
            // 
            uLine4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine4.BackColor = Color.Transparent;
            uLine4.LineColor = Color.SlateGray;
            uLine4.Location = new Point(7, 36);
            uLine4.Margin = new Padding(4);
            uLine4.Name = "uLine4";
            uLine4.Size = new Size(366, 14);
            uLine4.TabIndex = 0;
            uLine4.Text = "uLine1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(uPanel6, 2, 2);
            tableLayoutPanel1.Controls.Add(uPanel5, 1, 2);
            tableLayoutPanel1.Controls.Add(uPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(uPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(uPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(uLine5, 0, 1);
            tableLayoutPanel1.Controls.Add(uPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(378, 14);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(950, 484);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // uPanel6
            // 
            uPanel6.BgColor = Color.Transparent;
            uPanel6.BorderColor = Color.SlateGray;
            uPanel6.BorderWidth = 1;
            uPanel6.Controls.Add(lblHistoryL_B);
            uPanel6.Controls.Add(lblHistoryH_B);
            uPanel6.Controls.Add(label25);
            uPanel6.Controls.Add(label26);
            uPanel6.Controls.Add(label27);
            uPanel6.Dock = DockStyle.Fill;
            uPanel6.Location = new Point(644, 264);
            uPanel6.Margin = new Padding(12);
            uPanel6.Name = "uPanel6";
            uPanel6.Size = new Size(294, 208);
            uPanel6.TabIndex = 6;
            // 
            // lblHistoryL_B
            // 
            lblHistoryL_B.BackColor = Color.Transparent;
            lblHistoryL_B.DecimalCount = 0;
            lblHistoryL_B.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryL_B.ForeColor = Color.WhiteSmoke;
            lblHistoryL_B.Location = new Point(150, 133);
            lblHistoryL_B.Margin = new Padding(4, 0, 4, 0);
            lblHistoryL_B.Name = "lblHistoryL_B";
            lblHistoryL_B.ParaName = null;
            lblHistoryL_B.Size = new Size(148, 44);
            lblHistoryL_B.TabIndex = 2;
            lblHistoryL_B.Text = "1 cd/m2";
            lblHistoryL_B.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryL_B.Unit = "cd/m2";
            lblHistoryL_B.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHistoryH_B
            // 
            lblHistoryH_B.BackColor = Color.Transparent;
            lblHistoryH_B.DecimalCount = 0;
            lblHistoryH_B.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryH_B.ForeColor = Color.WhiteSmoke;
            lblHistoryH_B.Location = new Point(150, 86);
            lblHistoryH_B.Margin = new Padding(4, 0, 4, 0);
            lblHistoryH_B.Name = "lblHistoryH_B";
            lblHistoryH_B.ParaName = null;
            lblHistoryH_B.Size = new Size(148, 44);
            lblHistoryH_B.TabIndex = 2;
            lblHistoryH_B.Text = "99 cd/m2";
            lblHistoryH_B.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryH_B.Unit = "cd/m2";
            lblHistoryH_B.Value = new decimal(new int[] { 99, 0, 0, 0 });
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.Transparent;
            label25.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label25.ForeColor = Color.FromArgb(174, 186, 189);
            label25.Location = new Point(24, 143);
            label25.Margin = new Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new Size(123, 30);
            label25.TabIndex = 1;
            label25.Text = "历史最低：";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Transparent;
            label26.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label26.ForeColor = Color.FromArgb(174, 186, 189);
            label26.Location = new Point(24, 96);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(123, 30);
            label26.TabIndex = 1;
            label26.Text = "历史最高：";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label27.ForeColor = Color.White;
            label27.Location = new Point(9, 20);
            label27.Margin = new Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new Size(127, 36);
            label27.TabIndex = 1;
            label27.Text = "历史数据";
            // 
            // uPanel5
            // 
            uPanel5.BgColor = Color.Transparent;
            uPanel5.BorderColor = Color.SlateGray;
            uPanel5.BorderWidth = 1;
            uPanel5.Controls.Add(lblHistoryL_H);
            uPanel5.Controls.Add(lblHistoryH_H);
            uPanel5.Controls.Add(label22);
            uPanel5.Controls.Add(label23);
            uPanel5.Controls.Add(label24);
            uPanel5.Dock = DockStyle.Fill;
            uPanel5.Location = new Point(328, 264);
            uPanel5.Margin = new Padding(12);
            uPanel5.Name = "uPanel5";
            uPanel5.Size = new Size(292, 208);
            uPanel5.TabIndex = 5;
            // 
            // lblHistoryL_H
            // 
            lblHistoryL_H.BackColor = Color.Transparent;
            lblHistoryL_H.DecimalCount = 0;
            lblHistoryL_H.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryL_H.ForeColor = Color.WhiteSmoke;
            lblHistoryL_H.Location = new Point(152, 133);
            lblHistoryL_H.Margin = new Padding(4, 0, 4, 0);
            lblHistoryL_H.Name = "lblHistoryL_H";
            lblHistoryL_H.ParaName = null;
            lblHistoryL_H.Size = new Size(127, 44);
            lblHistoryL_H.TabIndex = 2;
            lblHistoryL_H.Text = "10 %";
            lblHistoryL_H.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryL_H.Unit = "%";
            lblHistoryL_H.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lblHistoryH_H
            // 
            lblHistoryH_H.BackColor = Color.Transparent;
            lblHistoryH_H.DecimalCount = 0;
            lblHistoryH_H.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryH_H.ForeColor = Color.WhiteSmoke;
            lblHistoryH_H.Location = new Point(152, 86);
            lblHistoryH_H.Margin = new Padding(4, 0, 4, 0);
            lblHistoryH_H.Name = "lblHistoryH_H";
            lblHistoryH_H.ParaName = null;
            lblHistoryH_H.Size = new Size(127, 44);
            lblHistoryH_H.TabIndex = 2;
            lblHistoryH_H.Text = "98 %";
            lblHistoryH_H.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryH_H.Unit = "%";
            lblHistoryH_H.Value = new decimal(new int[] { 98, 0, 0, 0 });
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label22.ForeColor = Color.FromArgb(174, 186, 189);
            label22.Location = new Point(24, 143);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(123, 30);
            label22.TabIndex = 1;
            label22.Text = "历史最低：";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Transparent;
            label23.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label23.ForeColor = Color.FromArgb(174, 186, 189);
            label23.Location = new Point(24, 96);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(123, 30);
            label23.TabIndex = 1;
            label23.Text = "历史最高：";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label24.ForeColor = Color.White;
            label24.Location = new Point(9, 20);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(127, 36);
            label24.TabIndex = 1;
            label24.Text = "历史数据";
            // 
            // uPanel4
            // 
            uPanel4.BgColor = Color.Transparent;
            uPanel4.BorderColor = Color.SlateGray;
            uPanel4.BorderWidth = 1;
            uPanel4.Controls.Add(lblHistoryL_T);
            uPanel4.Controls.Add(lblHistoryH_T);
            uPanel4.Controls.Add(label21);
            uPanel4.Controls.Add(label19);
            uPanel4.Controls.Add(label20);
            uPanel4.Dock = DockStyle.Fill;
            uPanel4.Location = new Point(12, 264);
            uPanel4.Margin = new Padding(12);
            uPanel4.Name = "uPanel4";
            uPanel4.Size = new Size(292, 208);
            uPanel4.TabIndex = 4;
            // 
            // lblHistoryL_T
            // 
            lblHistoryL_T.BackColor = Color.Transparent;
            lblHistoryL_T.DecimalCount = 1;
            lblHistoryL_T.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryL_T.ForeColor = Color.WhiteSmoke;
            lblHistoryL_T.Location = new Point(147, 133);
            lblHistoryL_T.Margin = new Padding(4, 0, 4, 0);
            lblHistoryL_T.Name = "lblHistoryL_T";
            lblHistoryL_T.ParaName = null;
            lblHistoryL_T.Size = new Size(127, 44);
            lblHistoryL_T.TabIndex = 2;
            lblHistoryL_T.Text = "5.5 °C";
            lblHistoryL_T.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryL_T.Unit = "°C";
            lblHistoryL_T.Value = new decimal(new int[] { 55, 0, 0, 65536 });
            // 
            // lblHistoryH_T
            // 
            lblHistoryH_T.BackColor = Color.Transparent;
            lblHistoryH_T.DecimalCount = 1;
            lblHistoryH_T.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblHistoryH_T.ForeColor = Color.WhiteSmoke;
            lblHistoryH_T.Location = new Point(147, 86);
            lblHistoryH_T.Margin = new Padding(4, 0, 4, 0);
            lblHistoryH_T.Name = "lblHistoryH_T";
            lblHistoryH_T.ParaName = null;
            lblHistoryH_T.Size = new Size(127, 44);
            lblHistoryH_T.TabIndex = 2;
            lblHistoryH_T.Text = "24.5 °C";
            lblHistoryH_T.TextAlign = ContentAlignment.MiddleCenter;
            lblHistoryH_T.Unit = "°C";
            lblHistoryH_T.Value = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Transparent;
            label21.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label21.ForeColor = Color.FromArgb(174, 186, 189);
            label21.Location = new Point(24, 143);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(123, 30);
            label21.TabIndex = 1;
            label21.Text = "历史最低：";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label19.ForeColor = Color.FromArgb(174, 186, 189);
            label19.Location = new Point(24, 96);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(123, 30);
            label19.TabIndex = 1;
            label19.Text = "历史最高：";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label20.ForeColor = Color.White;
            label20.Location = new Point(9, 20);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(127, 36);
            label20.TabIndex = 1;
            label20.Text = "历史数据";
            // 
            // uPanel3
            // 
            uPanel3.BgColor = Color.FromArgb(25, 55, 87);
            uPanel3.BgColor2 = Color.FromArgb(5, 55, 80);
            uPanel3.BorderColor = Color.DarkSlateGray;
            uPanel3.BorderWidth = 1;
            uPanel3.Controls.Add(lblValue_B);
            uPanel3.Controls.Add(label17);
            uPanel3.Controls.Add(label18);
            uPanel3.Controls.Add(pbAlarm_B);
            uPanel3.Controls.Add(pictureBox6);
            uPanel3.Dock = DockStyle.Fill;
            uPanel3.Location = new Point(644, 12);
            uPanel3.Margin = new Padding(12);
            uPanel3.Name = "uPanel3";
            uPanel3.Size = new Size(294, 208);
            uPanel3.TabIndex = 3;
            // 
            // lblValue_B
            // 
            lblValue_B.BackColor = Color.Transparent;
            lblValue_B.DecimalCount = 0;
            lblValue_B.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblValue_B.ForeColor = Color.Gold;
            lblValue_B.Location = new Point(21, 86);
            lblValue_B.Margin = new Padding(4, 0, 4, 0);
            lblValue_B.Name = "lblValue_B";
            lblValue_B.ParaName = null;
            lblValue_B.Size = new Size(277, 64);
            lblValue_B.TabIndex = 2;
            lblValue_B.Text = "75 cd/m2";
            lblValue_B.TextAlign = ContentAlignment.MiddleCenter;
            lblValue_B.Unit = "cd/m2";
            lblValue_B.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label17.ForeColor = Color.FromArgb(174, 186, 189);
            label17.Location = new Point(104, 160);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(101, 30);
            label17.TabIndex = 1;
            label17.Text = "当前亮度";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label18.ForeColor = Color.White;
            label18.Location = new Point(94, 23);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(127, 36);
            label18.TabIndex = 1;
            label18.Text = "亮度监控";
            // 
            // pbAlarm_B
            // 
            pbAlarm_B.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAlarm_B.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.baojing_h;
            pbAlarm_B.Location = new Point(213, 16);
            pbAlarm_B.Margin = new Padding(4);
            pbAlarm_B.Name = "pbAlarm_B";
            pbAlarm_B.Size = new Size(48, 45);
            pbAlarm_B.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAlarm_B.TabIndex = 0;
            pbAlarm_B.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.liangdu;
            pictureBox6.Location = new Point(21, 8);
            pictureBox6.Margin = new Padding(4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(48, 48);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // uPanel2
            // 
            uPanel2.BgColor = Color.FromArgb(25, 55, 87);
            uPanel2.BgColor2 = Color.FromArgb(5, 55, 80);
            uPanel2.BorderColor = Color.DarkSlateGray;
            uPanel2.BorderWidth = 1;
            uPanel2.Controls.Add(lblValue_H);
            uPanel2.Controls.Add(label15);
            uPanel2.Controls.Add(label16);
            uPanel2.Controls.Add(pbAlarm_H);
            uPanel2.Controls.Add(pictureBox4);
            uPanel2.Dock = DockStyle.Fill;
            uPanel2.Location = new Point(328, 12);
            uPanel2.Margin = new Padding(12);
            uPanel2.Name = "uPanel2";
            uPanel2.Size = new Size(292, 208);
            uPanel2.TabIndex = 2;
            // 
            // lblValue_H
            // 
            lblValue_H.BackColor = Color.Transparent;
            lblValue_H.DecimalCount = 0;
            lblValue_H.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblValue_H.ForeColor = Color.Gold;
            lblValue_H.Location = new Point(21, 86);
            lblValue_H.Margin = new Padding(4, 0, 4, 0);
            lblValue_H.Name = "lblValue_H";
            lblValue_H.ParaName = null;
            lblValue_H.Size = new Size(277, 64);
            lblValue_H.TabIndex = 2;
            lblValue_H.Text = "55 %";
            lblValue_H.TextAlign = ContentAlignment.MiddleCenter;
            lblValue_H.Unit = "%";
            lblValue_H.Value = new decimal(new int[] { 55, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label15.ForeColor = Color.FromArgb(174, 186, 189);
            label15.Location = new Point(104, 160);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(101, 30);
            label15.TabIndex = 1;
            label15.Text = "当前湿度";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label16.ForeColor = Color.White;
            label16.Location = new Point(94, 23);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(127, 36);
            label16.TabIndex = 1;
            label16.Text = "湿度监控";
            // 
            // pbAlarm_H
            // 
            pbAlarm_H.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAlarm_H.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.baojing_h;
            pbAlarm_H.Location = new Point(213, 16);
            pbAlarm_H.Margin = new Padding(4);
            pbAlarm_H.Name = "pbAlarm_H";
            pbAlarm_H.Size = new Size(48, 45);
            pbAlarm_H.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAlarm_H.TabIndex = 0;
            pbAlarm_H.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.humidity;
            pictureBox4.Location = new Point(21, 8);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // uLine5
            // 
            uLine5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(uLine5, 3);
            uLine5.LineColor = Color.SlateGray;
            uLine5.Location = new Point(4, 236);
            uLine5.Margin = new Padding(4);
            uLine5.Name = "uLine5";
            uLine5.Size = new Size(942, 12);
            uLine5.TabIndex = 0;
            uLine5.Text = "uLine5";
            // 
            // uPanel1
            // 
            uPanel1.BgColor = Color.FromArgb(25, 55, 87);
            uPanel1.BgColor2 = Color.FromArgb(5, 55, 80);
            uPanel1.BorderColor = Color.DarkSlateGray;
            uPanel1.BorderWidth = 1;
            uPanel1.Controls.Add(lblValue_T);
            uPanel1.Controls.Add(label14);
            uPanel1.Controls.Add(label13);
            uPanel1.Controls.Add(pbAlarm_T);
            uPanel1.Controls.Add(pictureBox1);
            uPanel1.Dock = DockStyle.Fill;
            uPanel1.Location = new Point(12, 12);
            uPanel1.Margin = new Padding(12);
            uPanel1.Name = "uPanel1";
            uPanel1.Size = new Size(292, 208);
            uPanel1.TabIndex = 1;
            // 
            // lblValue_T
            // 
            lblValue_T.BackColor = Color.Transparent;
            lblValue_T.DecimalCount = 1;
            lblValue_T.Font = new Font("Microsoft YaHei UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblValue_T.ForeColor = Color.Gold;
            lblValue_T.Location = new Point(21, 86);
            lblValue_T.Margin = new Padding(4, 0, 4, 0);
            lblValue_T.Name = "lblValue_T";
            lblValue_T.ParaName = null;
            lblValue_T.Size = new Size(277, 64);
            lblValue_T.TabIndex = 2;
            lblValue_T.Text = "24.5 °C";
            lblValue_T.TextAlign = ContentAlignment.MiddleCenter;
            lblValue_T.Unit = "°C";
            lblValue_T.Value = new decimal(new int[] { 245, 0, 0, 65536 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label14.ForeColor = Color.FromArgb(174, 186, 189);
            label14.Location = new Point(104, 160);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(101, 30);
            label14.TabIndex = 1;
            label14.Text = "当前温度";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("微软雅黑", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label13.ForeColor = Color.White;
            label13.Location = new Point(94, 23);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(127, 36);
            label13.TabIndex = 1;
            label13.Text = "温度监控";
            // 
            // pbAlarm_T
            // 
            pbAlarm_T.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbAlarm_T.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.baojing_h;
            pbAlarm_T.Location = new Point(213, 16);
            pbAlarm_T.Margin = new Padding(4);
            pbAlarm_T.Name = "pbAlarm_T";
            pbAlarm_T.Size = new Size(48, 45);
            pbAlarm_T.SizeMode = PictureBoxSizeMode.AutoSize;
            pbAlarm_T.TabIndex = 0;
            pbAlarm_T.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = IntelligentEquipmentMonitorAndWarningCenter.Properties.Resources.temperature;
            pictureBox1.Location = new Point(21, 8);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uLine6
            // 
            uLine6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine6.LineColor = Color.SlateGray;
            uLine6.Location = new Point(390, 524);
            uLine6.Margin = new Padding(4);
            uLine6.Name = "uLine6";
            uLine6.Size = new Size(934, 13);
            uLine6.TabIndex = 0;
            uLine6.Text = "uLine5";
            // 
            // dgvDataList
            // 
            dgvDataList.AllowUserToAddRows = false;
            dgvDataList.AllowUserToDeleteRows = false;
            dgvDataList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataList.BackgroundColor = Color.FromArgb(25, 55, 87);
            dgvDataList.BorderStyle = BorderStyle.None;
            dgvDataList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(49, 87, 113);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataList.ColumnHeadersHeight = 40;
            dgvDataList.Columns.AddRange(new DataGridViewColumn[] { colId, colCurTime, colTemperature, colHumidity, colBrightness });
            dgvDataList.EnableHeadersVisualStyles = false;
            dgvDataList.GridColor = Color.SlateGray;
            dgvDataList.Location = new Point(390, 560);
            dgvDataList.Margin = new Padding(4);
            dgvDataList.Name = "dgvDataList";
            dgvDataList.RowHeadersVisible = false;
            dgvDataList.RowHeadersWidth = 51;
            dgvDataList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvDataList.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(44, 78, 100);
            dgvDataList.RowTemplate.DefaultCellStyle.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgvDataList.RowTemplate.DefaultCellStyle.ForeColor = Color.Silver;
            dgvDataList.RowTemplate.DefaultCellStyle.Padding = new Padding(5, 0, 0, 0);
            dgvDataList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 78, 110);
            dgvDataList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvDataList.RowTemplate.Height = 35;
            dgvDataList.RowTemplate.ReadOnly = true;
            dgvDataList.ScrollBars = ScrollBars.Vertical;
            dgvDataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataList.Size = new Size(938, 385);
            dgvDataList.TabIndex = 9;
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
            // colCurTime
            // 
            colCurTime.DataPropertyName = "CollectionTime";
            colCurTime.FillWeight = 150F;
            colCurTime.HeaderText = "采集时间";
            colCurTime.MinimumWidth = 6;
            colCurTime.Name = "colCurTime";
            colCurTime.ReadOnly = true;
            // 
            // colTemperature
            // 
            colTemperature.DataPropertyName = "Temperature";
            colTemperature.HeaderText = "当前温度(℃)";
            colTemperature.MinimumWidth = 6;
            colTemperature.Name = "colTemperature";
            colTemperature.ReadOnly = true;
            // 
            // colHumidity
            // 
            colHumidity.DataPropertyName = "Humidity";
            colHumidity.HeaderText = "当前湿度(%)";
            colHumidity.MinimumWidth = 6;
            colHumidity.Name = "colHumidity";
            colHumidity.ReadOnly = true;
            // 
            // colBrightness
            // 
            colBrightness.DataPropertyName = "Brightness";
            colBrightness.FillWeight = 150F;
            colBrightness.HeaderText = "当前亮度(cd/m2)";
            colBrightness.MinimumWidth = 6;
            colBrightness.Name = "colBrightness";
            colBrightness.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("黑体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.SkyBlue;
            label1.Location = new Point(409, 512);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 10;
            label1.Text = "实时数据";
            // 
            // FrmDeviceMonitor
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1628, 956);
            Controls.Add(label1);
            Controls.Add(dgvDataList);
            Controls.Add(uLine6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(uGroupPanel14);
            Controls.Add(uGroupPanel12);
            Controls.Add(uGroupPanel13);
            Controls.Add(uGroupPanel11);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmDeviceMonitor";
            Text = "FrmDeviceMonitor";
            Load += FrmDeviceMonitor_Load;
            uGroupPanel11.ResumeLayout(false);
            uGroupPanel11.PerformLayout();
            uGroupPanel12.ResumeLayout(false);
            uGroupPanel12.PerformLayout();
            uGroupPanel13.ResumeLayout(false);
            uGroupPanel13.PerformLayout();
            uGroupPanel14.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            uPanel6.ResumeLayout(false);
            uPanel6.PerformLayout();
            uPanel5.ResumeLayout(false);
            uPanel5.PerformLayout();
            uPanel4.ResumeLayout(false);
            uPanel4.PerformLayout();
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_H).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAlarm_T).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel1 uGroupPanel11;
        private Zhaoxi.CustControls.ULine uLine1;
        private Zhaoxi.CustControls.UGroupPanel1 uGroupPanel12;
        private Zhaoxi.CustControls.ULine uLine2;
        private Zhaoxi.CustControls.UGroupPanel1 uGroupPanel13;
        private Zhaoxi.CustControls.ULine uLine3;
        private Zhaoxi.CustControls.UGroupPanel1 uGroupPanel14;
        private Zhaoxi.CustControls.ULine uLine4;
        private TableLayoutPanel tableLayoutPanel1;
        private Zhaoxi.CustControls.ULine uLine5;
        private Zhaoxi.CustControls.ULine uLine6;
        private DataGridView dgvDataList;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCurTime;
        private DataGridViewTextBoxColumn colTemperature;
        private DataGridViewTextBoxColumn colHumidity;
        private DataGridViewTextBoxColumn colBrightness;
        private Label label1;
        private Zhaoxi.CustControls.UButton btnRefreshPorts;
        private ComboBox cboPorts;
        private Label label2;
        private Zhaoxi.CustControls.UButton btnConnect;
        private Zhaoxi.CustControls.USwitch switchAll;
        private Label label3;
        private Zhaoxi.CustControls.UJogSwitch jswLight05;
        private Zhaoxi.CustControls.UJogSwitch jswLight04;
        private Zhaoxi.CustControls.UJogSwitch jswLight03;
        private Zhaoxi.CustControls.UJogSwitch jswLight02;
        private Zhaoxi.CustControls.UJogSwitch jswLight01;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Zhaoxi.CustControls.UNumericBox numAllAlarms;
        private Label label9;
        private Zhaoxi.CustControls.UNumericBox numAlarms_B;
        private Zhaoxi.CustControls.UNumericBox numAlarms_H;
        private Zhaoxi.CustControls.UNumericBox numAlarms_T;
        private Label label12;
        private Label label11;
        private Label label10;
        private Zhaoxi.CustControls.UPanel uPanel1;
        private PictureBox pictureBox1;
        private Zhaoxi.CustControls.ParaTextBox lblValue_T;
        private Label label13;
        private PictureBox pbAlarm_T;
        private Zhaoxi.CustControls.UPanel uPanel3;
        private Zhaoxi.CustControls.ParaTextBox lblValue_B;
        private Label label17;
        private Label label18;
        private PictureBox pbAlarm_B;
        private PictureBox pictureBox6;
        private Zhaoxi.CustControls.UPanel uPanel2;
        private Zhaoxi.CustControls.ParaTextBox lblValue_H;
        private Label label15;
        private Label label16;
        private PictureBox pbAlarm_H;
        private PictureBox pictureBox4;
        private Label label14;
        private Zhaoxi.CustControls.UPanel uPanel4;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryH_T;
        private Label label19;
        private Label label20;
        private Zhaoxi.CustControls.UPanel uPanel6;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryL_B;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryH_B;
        private Label label25;
        private Label label26;
        private Label label27;
        private Zhaoxi.CustControls.UPanel uPanel5;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryL_H;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryH_H;
        private Label label22;
        private Label label23;
        private Label label24;
        private Zhaoxi.CustControls.ParaTextBox lblHistoryL_T;
        private Label label21;
        private Zhaoxi.CustControls.UMeter meter_B;
        private Zhaoxi.CustControls.UMeter meter_H;
        private Zhaoxi.CustControls.UMeter meter_T;
    }
}