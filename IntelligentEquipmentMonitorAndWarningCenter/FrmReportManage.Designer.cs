namespace IntelligentDeviceMonitorAndWarningCenter
{
    partial class FrmReportManage
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
       private Zhaoxi.CustControls.UButton btnStatistics;
        private System.Windows.Forms.DateTimePicker dtTime;
        private System.Windows.Forms.ComboBox cboReportTypes;
        private System.Windows.Forms.RadioButton rbtnData;
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            uGroupPanel21 = new Zhaoxi.CustControls.UGroupPanel2();
            btnExport = new Zhaoxi.CustControls.UButton();
            btnStatistics = new Zhaoxi.CustControls.UButton();
            dtTime = new DateTimePicker();
            cboReportTypes = new ComboBox();
            rbtnData = new RadioButton();
            rbtnAlarm = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            uLine6 = new Zhaoxi.CustControls.ULine();
            lblTitle = new Label();
            panelAlarm = new Panel();
            numAlarmCount_Un = new Zhaoxi.CustControls.UNumericBox();
            numAlarmCount_L = new Zhaoxi.CustControls.UNumericBox();
            numAlarmCount_H = new Zhaoxi.CustControls.UNumericBox();
            numAlarmCount = new Zhaoxi.CustControls.UNumericBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelData = new Panel();
            numAvg_B = new Zhaoxi.CustControls.UNumericBox();
            numAvg_H = new Zhaoxi.CustControls.UNumericBox();
            label11 = new Label();
            numAvg_T = new Zhaoxi.CustControls.UNumericBox();
            label10 = new Label();
            numCollectionCount = new Zhaoxi.CustControls.UNumericBox();
            label8 = new Label();
            label9 = new Label();
            dgvDataList = new DataGridView();
            pager = new Zhaoxi.CustControls.UPager();
            uGroupPanel21.SuspendLayout();
            panelAlarm.SuspendLayout();
            panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataList).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel21
            // 
            uGroupPanel21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel21.Background = Color.Black;
            uGroupPanel21.Controls.Add(btnExport);
            uGroupPanel21.Controls.Add(btnStatistics);
            uGroupPanel21.Controls.Add(dtTime);
            uGroupPanel21.Controls.Add(cboReportTypes);
            uGroupPanel21.Controls.Add(rbtnData);
            uGroupPanel21.Controls.Add(rbtnAlarm);
            uGroupPanel21.Controls.Add(label5);
            uGroupPanel21.Controls.Add(label4);
            uGroupPanel21.Controls.Add(label2);
            uGroupPanel21.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel21.Location = new Point(12, 12);
            uGroupPanel21.Margin = new Padding(4);
            uGroupPanel21.Name = "uGroupPanel21";
            uGroupPanel21.Padding = new Padding(4);
            uGroupPanel21.PrimaryColor = Color.SkyBlue;
            uGroupPanel21.Size = new Size(1649, 125);
            uGroupPanel21.TabIndex = 1;
            uGroupPanel21.TabStop = false;
            uGroupPanel21.Text = "报表查询条件";
            // 
            // btnExport
            // 
            btnExport.BgColor = Color.Teal;
            btnExport.BorderColor = Color.FromArgb(25, 55, 87);
            btnExport.BorderWidth = 1;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnExport.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.FocusBgColor = Color.FromArgb(0, 64, 64);
            btnExport.FocusForeColor = Color.White;
            btnExport.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(1437, 56);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(99, 42);
            btnExport.TabIndex = 7;
            btnExport.Text = "导出";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnStatistics
            // 
            btnStatistics.BgColor = Color.FromArgb(255, 128, 0);
            btnStatistics.BgColor2 = Color.FromArgb(255, 192, 128);
            btnStatistics.BorderColor = Color.FromArgb(25, 55, 87);
            btnStatistics.BorderWidth = 1;
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnStatistics.FlatStyle = FlatStyle.Flat;
            btnStatistics.FocusBgColor = Color.FromArgb(192, 64, 0);
            btnStatistics.FocusForeColor = Color.White;
            btnStatistics.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnStatistics.ForeColor = Color.White;
            btnStatistics.Location = new Point(1309, 56);
            btnStatistics.Margin = new Padding(4);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(99, 42);
            btnStatistics.TabIndex = 7;
            btnStatistics.Text = "统计";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // dtTime
            // 
            dtTime.CalendarFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtTime.CustomFormat = "yyyy-MM-dd";
            dtTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtTime.Format = DateTimePickerFormat.Custom;
            dtTime.Location = new Point(1080, 59);
            dtTime.Margin = new Padding(4);
            dtTime.Name = "dtTime";
            dtTime.Size = new Size(179, 31);
            dtTime.TabIndex = 6;
            // 
            // cboReportTypes
            // 
            cboReportTypes.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cboReportTypes.FormattingEnabled = true;
            cboReportTypes.Items.AddRange(new object[] { "日报表", "周报表", "月报表" });
            cboReportTypes.Location = new Point(687, 59);
            cboReportTypes.Margin = new Padding(4);
            cboReportTypes.Name = "cboReportTypes";
            cboReportTypes.Size = new Size(230, 32);
            cboReportTypes.TabIndex = 5;
            // 
            // rbtnData
            // 
            rbtnData.AutoSize = true;
            rbtnData.BackColor = Color.Transparent;
            rbtnData.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnData.ForeColor = Color.Silver;
            rbtnData.Location = new Point(350, 64);
            rbtnData.Margin = new Padding(4);
            rbtnData.Name = "rbtnData";
            rbtnData.Size = new Size(145, 29);
            rbtnData.TabIndex = 3;
            rbtnData.Text = "实时数据报表";
            rbtnData.UseVisualStyleBackColor = false;
            // 
            // rbtnAlarm
            // 
            rbtnAlarm.AutoSize = true;
            rbtnAlarm.BackColor = Color.Transparent;
            rbtnAlarm.Checked = true;
            rbtnAlarm.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            rbtnAlarm.ForeColor = Color.SteelBlue;
            rbtnAlarm.Location = new Point(175, 65);
            rbtnAlarm.Margin = new Padding(4);
            rbtnAlarm.Name = "rbtnAlarm";
            rbtnAlarm.Size = new Size(145, 29);
            rbtnAlarm.TabIndex = 3;
            rbtnAlarm.TabStop = true;
            rbtnAlarm.Text = "异常记录报表";
            rbtnAlarm.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(957, 65);
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
            label4.Location = new Point(562, 65);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 24);
            label4.TabIndex = 2;
            label4.Text = "报表类型：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(48, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "统计类别：";
            // 
            // uLine6
            // 
            uLine6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine6.LineColor = Color.SlateGray;
            uLine6.Location = new Point(11, 191);
            uLine6.Margin = new Padding(4);
            uLine6.Name = "uLine6";
            uLine6.Size = new Size(1652, 13);
            uLine6.TabIndex = 15;
            uLine6.Text = "uLine5";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("黑体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.SkyBlue;
            lblTitle.Location = new Point(29, 166);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 22);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "统计结果";
            // 
            // panelAlarm
            // 
            panelAlarm.Controls.Add(numAlarmCount_Un);
            panelAlarm.Controls.Add(numAlarmCount_L);
            panelAlarm.Controls.Add(numAlarmCount_H);
            panelAlarm.Controls.Add(numAlarmCount);
            panelAlarm.Controls.Add(label7);
            panelAlarm.Controls.Add(label6);
            panelAlarm.Controls.Add(label3);
            panelAlarm.Controls.Add(label1);
            panelAlarm.Location = new Point(15, 211);
            panelAlarm.Margin = new Padding(4);
            panelAlarm.Name = "panelAlarm";
            panelAlarm.Size = new Size(1646, 74);
            panelAlarm.TabIndex = 17;
            // 
            // numAlarmCount_Un
            // 
            numAlarmCount_Un.BackColor = Color.Transparent;
            numAlarmCount_Un.BgColor = Color.Transparent;
            numAlarmCount_Un.BorderColor = Color.Black;
            numAlarmCount_Un.BorderWidth = 0;
            numAlarmCount_Un.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarmCount_Un.ForeColor = Color.DeepSkyBlue;
            numAlarmCount_Un.InnerPadding = new Padding(3);
            numAlarmCount_Un.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAlarmCount_Un.ItemSpace = 2;
            numAlarmCount_Un.Location = new Point(1228, 13);
            numAlarmCount_Un.Margin = new Padding(4);
            numAlarmCount_Un.Name = "numAlarmCount_Un";
            numAlarmCount_Un.NumCount = 4;
            numAlarmCount_Un.Size = new Size(153, 48);
            numAlarmCount_Un.TabIndex = 3;
            numAlarmCount_Un.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numAlarmCount_L
            // 
            numAlarmCount_L.BackColor = Color.Transparent;
            numAlarmCount_L.BgColor = Color.Transparent;
            numAlarmCount_L.BorderColor = Color.Black;
            numAlarmCount_L.BorderWidth = 0;
            numAlarmCount_L.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarmCount_L.ForeColor = Color.LightBlue;
            numAlarmCount_L.InnerPadding = new Padding(3);
            numAlarmCount_L.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAlarmCount_L.ItemSpace = 2;
            numAlarmCount_L.Location = new Point(836, 13);
            numAlarmCount_L.Margin = new Padding(4);
            numAlarmCount_L.Name = "numAlarmCount_L";
            numAlarmCount_L.NumCount = 4;
            numAlarmCount_L.Size = new Size(153, 48);
            numAlarmCount_L.TabIndex = 3;
            numAlarmCount_L.Value = new decimal(new int[] { 65, 0, 0, 0 });
            // 
            // numAlarmCount_H
            // 
            numAlarmCount_H.BackColor = Color.Transparent;
            numAlarmCount_H.BgColor = Color.Transparent;
            numAlarmCount_H.BorderColor = Color.Black;
            numAlarmCount_H.BorderWidth = 0;
            numAlarmCount_H.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarmCount_H.ForeColor = Color.FromArgb(255, 128, 0);
            numAlarmCount_H.InnerPadding = new Padding(3);
            numAlarmCount_H.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAlarmCount_H.ItemSpace = 2;
            numAlarmCount_H.Location = new Point(469, 13);
            numAlarmCount_H.Margin = new Padding(4);
            numAlarmCount_H.Name = "numAlarmCount_H";
            numAlarmCount_H.NumCount = 4;
            numAlarmCount_H.Size = new Size(153, 48);
            numAlarmCount_H.TabIndex = 3;
            numAlarmCount_H.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // numAlarmCount
            // 
            numAlarmCount.BackColor = Color.Transparent;
            numAlarmCount.BgColor = Color.Transparent;
            numAlarmCount.BorderColor = Color.Black;
            numAlarmCount.BorderWidth = 0;
            numAlarmCount.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAlarmCount.ForeColor = Color.Red;
            numAlarmCount.InnerPadding = new Padding(3);
            numAlarmCount.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAlarmCount.ItemSpace = 2;
            numAlarmCount.Location = new Point(159, 13);
            numAlarmCount.Margin = new Padding(4);
            numAlarmCount.Name = "numAlarmCount";
            numAlarmCount.NumCount = 5;
            numAlarmCount.Size = new Size(158, 48);
            numAlarmCount.TabIndex = 3;
            numAlarmCount.Value = new decimal(new int[] { 140, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(1118, 25);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 2;
            label7.Text = "取消异常：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(726, 25);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 2;
            label6.Text = "低值异常：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(359, 25);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "高值异常：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(26, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "异常记录总数：";
            // 
            // panelData
            // 
            panelData.Controls.Add(numAvg_B);
            panelData.Controls.Add(numAvg_H);
            panelData.Controls.Add(label11);
            panelData.Controls.Add(numAvg_T);
            panelData.Controls.Add(label10);
            panelData.Controls.Add(numCollectionCount);
            panelData.Controls.Add(label8);
            panelData.Controls.Add(label9);
            panelData.Location = new Point(15, 293);
            panelData.Margin = new Padding(4);
            panelData.Name = "panelData";
            panelData.Size = new Size(1649, 74);
            panelData.TabIndex = 17;
            // 
            // numAvg_B
            // 
            numAvg_B.BackColor = Color.Transparent;
            numAvg_B.BgColor = Color.Transparent;
            numAvg_B.BorderColor = Color.Black;
            numAvg_B.BorderWidth = 0;
            numAvg_B.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAvg_B.ForeColor = Color.Orange;
            numAvg_B.InnerPadding = new Padding(3);
            numAvg_B.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAvg_B.ItemSpace = 2;
            numAvg_B.Location = new Point(1228, 13);
            numAvg_B.Margin = new Padding(4);
            numAvg_B.Name = "numAvg_B";
            numAvg_B.NumCount = 2;
            numAvg_B.Size = new Size(82, 48);
            numAvg_B.TabIndex = 3;
            numAvg_B.Value = new decimal(new int[] { 55, 0, 0, 0 });
            // 
            // numAvg_H
            // 
            numAvg_H.BackColor = Color.Transparent;
            numAvg_H.BgColor = Color.Transparent;
            numAvg_H.BorderColor = Color.Black;
            numAvg_H.BorderWidth = 0;
            numAvg_H.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAvg_H.ForeColor = Color.DeepSkyBlue;
            numAvg_H.InnerPadding = new Padding(3);
            numAvg_H.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAvg_H.ItemSpace = 2;
            numAvg_H.Location = new Point(836, 13);
            numAvg_H.Margin = new Padding(4);
            numAvg_H.Name = "numAvg_H";
            numAvg_H.NumCount = 2;
            numAvg_H.Size = new Size(79, 48);
            numAvg_H.TabIndex = 3;
            numAvg_H.Value = new decimal(new int[] { 65, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(1118, 25);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(102, 25);
            label11.TabIndex = 2;
            label11.Text = "平均亮度：";
            // 
            // numAvg_T
            // 
            numAvg_T.BackColor = Color.Transparent;
            numAvg_T.BgColor = Color.Transparent;
            numAvg_T.BorderColor = Color.Black;
            numAvg_T.BorderWidth = 0;
            numAvg_T.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numAvg_T.ForeColor = Color.FromArgb(0, 192, 192);
            numAvg_T.InnerPadding = new Padding(3);
            numAvg_T.ItemBgColor = Color.FromArgb(54, 98, 140);
            numAvg_T.ItemSpace = 2;
            numAvg_T.Location = new Point(469, 13);
            numAvg_T.Margin = new Padding(4);
            numAvg_T.Name = "numAvg_T";
            numAvg_T.NumCount = 4;
            numAvg_T.Size = new Size(153, 48);
            numAvg_T.TabIndex = 3;
            numAvg_T.Value = new decimal(new int[] { 325, 0, 0, 65536 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(726, 25);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(102, 25);
            label10.TabIndex = 2;
            label10.Text = "平均湿度：";
            // 
            // numCollectionCount
            // 
            numCollectionCount.BackColor = Color.Transparent;
            numCollectionCount.BgColor = Color.Transparent;
            numCollectionCount.BorderColor = Color.Black;
            numCollectionCount.BorderWidth = 0;
            numCollectionCount.Font = new Font("微软雅黑", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 134);
            numCollectionCount.ForeColor = Color.White;
            numCollectionCount.InnerPadding = new Padding(3);
            numCollectionCount.ItemBgColor = Color.FromArgb(54, 98, 140);
            numCollectionCount.ItemSpace = 2;
            numCollectionCount.Location = new Point(123, 13);
            numCollectionCount.Margin = new Padding(4);
            numCollectionCount.Name = "numCollectionCount";
            numCollectionCount.NumCount = 6;
            numCollectionCount.Size = new Size(177, 48);
            numCollectionCount.TabIndex = 3;
            numCollectionCount.Value = new decimal(new int[] { 140, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(26, 25);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 2;
            label8.Text = "采集次数：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(359, 25);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 2;
            label9.Text = "平均温度：";
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 37, 58);
            dataGridViewCellStyle1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(16, 37, 58);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDataList.ColumnHeadersHeight = 35;
            dgvDataList.EnableHeadersVisualStyles = false;
            dgvDataList.GridColor = Color.SlateGray;
            dgvDataList.Location = new Point(11, 296);
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
            dgvDataList.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvDataList.ScrollBars = ScrollBars.Vertical;
            dgvDataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataList.Size = new Size(1650, 621);
            dgvDataList.TabIndex = 18;
            // 
            // pager
            // 
            pager.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pager.BackColor = Color.Transparent;
            pager.ForeColor = Color.Silver;
            pager.Location = new Point(1, 925);
            pager.Margin = new Padding(4);
            pager.Name = "pager";
            pager.PageSize = 15;
            pager.Size = new Size(1646, 62);
            pager.TabIndex = 19;
            pager.PageChanged += Pager_PageChanged;
            // 
            // FrmReportManage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1676, 1000);
            Controls.Add(pager);
            Controls.Add(dgvDataList);
            Controls.Add(panelData);
            Controls.Add(panelAlarm);
            Controls.Add(uLine6);
            Controls.Add(lblTitle);
            Controls.Add(uGroupPanel21);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FrmReportManage";
            Text = "FrmReportManage";
            uGroupPanel21.ResumeLayout(false);
            uGroupPanel21.PerformLayout();
            panelAlarm.ResumeLayout(false);
            panelAlarm.PerformLayout();
            panelData.ResumeLayout(false);
            panelData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel2 uGroupPanel21;
        private Zhaoxi.CustControls.UButton btnFind;
        private DateTimePicker dtEndTime;
        private DateTimePicker dtStartTime;
        private ComboBox cboInfoTypes;
        private RadioButton rbtnHistoryAlarm;
        private RadioButton rbtnAlarm;
        private Label label5;
        private Label label4;
        private Label label2;
        private Zhaoxi.CustControls.UButton btnExport;
        private Zhaoxi.CustControls.ULine uLine6;
        private Label lblTitle;
        private Panel panelAlarm;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private Panel panelData;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private Zhaoxi.CustControls.UNumericBox numAlarmCount_Un;
        private Zhaoxi.CustControls.UNumericBox numAlarmCount_L;
        private Zhaoxi.CustControls.UNumericBox numAlarmCount_H;
        private Zhaoxi.CustControls.UNumericBox numAlarmCount;
        private Zhaoxi.CustControls.UNumericBox numAvg_B;
        private Zhaoxi.CustControls.UNumericBox numAvg_H;
        private Zhaoxi.CustControls.UNumericBox numAvg_T;
        private Zhaoxi.CustControls.UNumericBox numCollectionCount;
        private DataGridView dgvDataList;
        private Zhaoxi.CustControls.UPager pager;
    }
}