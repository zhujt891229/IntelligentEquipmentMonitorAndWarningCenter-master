namespace IntelligentDeviceMonitorAndWarningCenter
{
    partial class FrmTrends
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            uGroupPanel21 = new Zhaoxi.CustControls.UGroupPanel2();
            uLine2 = new Zhaoxi.CustControls.ULine();
            uLine1 = new Zhaoxi.CustControls.ULine();
            btnHistoryFind = new Zhaoxi.CustControls.UButton();
            btnUpdate = new Zhaoxi.CustControls.UButton();
            dtEndTime = new DateTimePicker();
            dtStartTime = new DateTimePicker();
            panelAlarmStates = new Panel();
            valCount = new NumericUpDown();
            chk_B = new CheckBox();
            chk_H = new CheckBox();
            chk_T = new CheckBox();
            label3 = new Label();
            rbtnHistoryTrends = new RadioButton();
            rbtnRealTrends = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            uLine6 = new Zhaoxi.CustControls.ULine();
            lblTitle = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            uGroupPanel21.SuspendLayout();
            panelAlarmStates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel21
            // 
            uGroupPanel21.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel21.Background = Color.Black;
            uGroupPanel21.Controls.Add(uLine2);
            uGroupPanel21.Controls.Add(uLine1);
            uGroupPanel21.Controls.Add(btnHistoryFind);
            uGroupPanel21.Controls.Add(btnUpdate);
            uGroupPanel21.Controls.Add(dtEndTime);
            uGroupPanel21.Controls.Add(dtStartTime);
            uGroupPanel21.Controls.Add(panelAlarmStates);
            uGroupPanel21.Controls.Add(rbtnHistoryTrends);
            uGroupPanel21.Controls.Add(rbtnRealTrends);
            uGroupPanel21.Controls.Add(label6);
            uGroupPanel21.Controls.Add(label5);
            uGroupPanel21.Controls.Add(label1);
            uGroupPanel21.Controls.Add(label2);
            uGroupPanel21.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel21.Location = new Point(10, 12);
            uGroupPanel21.Margin = new Padding(4, 4, 4, 4);
            uGroupPanel21.Name = "uGroupPanel21";
            uGroupPanel21.Padding = new Padding(4, 4, 4, 4);
            uGroupPanel21.PrimaryColor = Color.SkyBlue;
            uGroupPanel21.Size = new Size(1585, 185);
            uGroupPanel21.TabIndex = 1;
            uGroupPanel21.TabStop = false;
            uGroupPanel21.Text = "曲线查询条件";
            // 
            // uLine2
            // 
            uLine2.BackColor = Color.Transparent;
            uLine2.IsHorizontal = false;
            uLine2.LineColor = Color.SlateGray;
            uLine2.Location = new Point(648, 34);
            uLine2.Margin = new Padding(4, 4, 4, 4);
            uLine2.Name = "uLine2";
            uLine2.Size = new Size(15, 145);
            uLine2.TabIndex = 2;
            uLine2.Text = "uLine1";
            // 
            // uLine1
            // 
            uLine1.BackColor = Color.Transparent;
            uLine1.IsHorizontal = false;
            uLine1.LineColor = Color.SlateGray;
            uLine1.Location = new Point(357, 32);
            uLine1.Margin = new Padding(4, 4, 4, 4);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(15, 145);
            uLine1.TabIndex = 2;
            uLine1.Text = "uLine1";
            // 
            // btnHistoryFind
            // 
            btnHistoryFind.BgColor = Color.SteelBlue;
            btnHistoryFind.BgColor2 = Color.DodgerBlue;
            btnHistoryFind.BorderColor = Color.FromArgb(25, 55, 87);
            btnHistoryFind.BorderWidth = 1;
            btnHistoryFind.FlatAppearance.BorderSize = 0;
            btnHistoryFind.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHistoryFind.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHistoryFind.FlatStyle = FlatStyle.Flat;
            btnHistoryFind.FocusBgColor = Color.FromArgb(39, 95, 156);
            btnHistoryFind.FocusForeColor = Color.White;
            btnHistoryFind.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnHistoryFind.ForeColor = Color.White;
            btnHistoryFind.Location = new Point(1342, 53);
            btnHistoryFind.Margin = new Padding(4, 4, 4, 4);
            btnHistoryFind.Name = "btnHistoryFind";
            btnHistoryFind.Size = new Size(131, 42);
            btnHistoryFind.TabIndex = 7;
            btnHistoryFind.Text = "历史查询";
            btnHistoryFind.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.BgColor = Color.FromArgb(255, 128, 0);
            btnUpdate.BgColor2 = Color.FromArgb(255, 192, 128);
            btnUpdate.BorderColor = Color.FromArgb(25, 55, 87);
            btnUpdate.BorderWidth = 1;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.FocusBgColor = Color.FromArgb(192, 64, 0);
            btnUpdate.FocusForeColor = Color.White;
            btnUpdate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(1342, 109);
            btnUpdate.Margin = new Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "开始更新";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dtEndTime
            // 
            dtEndTime.CalendarFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtEndTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtEndTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtEndTime.Format = DateTimePickerFormat.Custom;
            dtEndTime.Location = new Point(1072, 55);
            dtEndTime.Margin = new Padding(4, 4, 4, 4);
            dtEndTime.Name = "dtEndTime";
            dtEndTime.Size = new Size(218, 31);
            dtEndTime.TabIndex = 6;
            // 
            // dtStartTime
            // 
            dtStartTime.CalendarFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            dtStartTime.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtStartTime.Format = DateTimePickerFormat.Custom;
            dtStartTime.Location = new Point(804, 58);
            dtStartTime.Margin = new Padding(4, 4, 4, 4);
            dtStartTime.Name = "dtStartTime";
            dtStartTime.Size = new Size(211, 31);
            dtStartTime.TabIndex = 6;
            // 
            // panelAlarmStates
            // 
            panelAlarmStates.BackColor = Color.Transparent;
            panelAlarmStates.Controls.Add(valCount);
            panelAlarmStates.Controls.Add(chk_B);
            panelAlarmStates.Controls.Add(chk_H);
            panelAlarmStates.Controls.Add(chk_T);
            panelAlarmStates.Controls.Add(label3);
            panelAlarmStates.Location = new Point(21, 43);
            panelAlarmStates.Margin = new Padding(4, 4, 4, 4);
            panelAlarmStates.Name = "panelAlarmStates";
            panelAlarmStates.Size = new Size(312, 126);
            panelAlarmStates.TabIndex = 4;
            // 
            // valCount
            // 
            valCount.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            valCount.Location = new Point(136, 70);
            valCount.Margin = new Padding(4, 4, 4, 4);
            valCount.Name = "valCount";
            valCount.Size = new Size(136, 31);
            valCount.TabIndex = 3;
            valCount.TextAlign = HorizontalAlignment.Center;
            valCount.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // chk_B
            // 
            chk_B.AutoSize = true;
            chk_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chk_B.ForeColor = Color.DodgerBlue;
            chk_B.Location = new Point(218, 18);
            chk_B.Margin = new Padding(4, 4, 4, 4);
            chk_B.Name = "chk_B";
            chk_B.Size = new Size(72, 28);
            chk_B.TabIndex = 0;
            chk_B.Tag = "3";
            chk_B.Text = "亮度";
            chk_B.UseVisualStyleBackColor = true;
            // 
            // chk_H
            // 
            chk_H.AutoSize = true;
            chk_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chk_H.ForeColor = Color.Turquoise;
            chk_H.Location = new Point(119, 18);
            chk_H.Margin = new Padding(4, 4, 4, 4);
            chk_H.Name = "chk_H";
            chk_H.Size = new Size(72, 28);
            chk_H.TabIndex = 0;
            chk_H.Tag = "0";
            chk_H.Text = "湿度";
            chk_H.UseVisualStyleBackColor = true;
            // 
            // chk_T
            // 
            chk_T.AutoSize = true;
            chk_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            chk_T.ForeColor = Color.FromArgb(255, 128, 0);
            chk_T.Location = new Point(26, 18);
            chk_T.Margin = new Padding(4, 4, 4, 4);
            chk_T.Name = "chk_T";
            chk_T.Size = new Size(72, 28);
            chk_T.TabIndex = 0;
            chk_T.Tag = "2";
            chk_T.Text = "温度";
            chk_T.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(26, 74);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 2;
            label3.Text = "数据点数：";
            // 
            // rbtnHistoryTrends
            // 
            rbtnHistoryTrends.AutoSize = true;
            rbtnHistoryTrends.BackColor = Color.Transparent;
            rbtnHistoryTrends.Font = new Font("微软雅黑", 9F);
            rbtnHistoryTrends.ForeColor = Color.Silver;
            rbtnHistoryTrends.Location = new Point(471, 131);
            rbtnHistoryTrends.Margin = new Padding(4, 4, 4, 4);
            rbtnHistoryTrends.Name = "rbtnHistoryTrends";
            rbtnHistoryTrends.Size = new Size(107, 28);
            rbtnHistoryTrends.TabIndex = 3;
            rbtnHistoryTrends.Text = "历史曲线";
            rbtnHistoryTrends.UseVisualStyleBackColor = false;
            // 
            // rbtnRealTrends
            // 
            rbtnRealTrends.AutoSize = true;
            rbtnRealTrends.BackColor = Color.Transparent;
            rbtnRealTrends.Font = new Font("微软雅黑", 9F);
            rbtnRealTrends.ForeColor = Color.Silver;
            rbtnRealTrends.Location = new Point(471, 89);
            rbtnRealTrends.Margin = new Padding(4, 4, 4, 4);
            rbtnRealTrends.Name = "rbtnRealTrends";
            rbtnRealTrends.Size = new Size(107, 28);
            rbtnRealTrends.TabIndex = 3;
            rbtnRealTrends.Text = "实时曲线";
            rbtnRealTrends.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(1028, 64);
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
            label5.Location = new Point(691, 61);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 2;
            label5.Text = "查询时间：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(804, 116);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 24);
            label1.TabIndex = 2;
            label1.Text = "不能超过10小时的时间范围";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(439, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 2;
            label2.Text = "曲线类型：";
            // 
            // uLine6
            // 
            uLine6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            uLine6.LineColor = Color.SlateGray;
            uLine6.Location = new Point(10, 247);
            uLine6.Margin = new Padding(4, 4, 4, 4);
            uLine6.Name = "uLine6";
            uLine6.Size = new Size(1583, 13);
            uLine6.TabIndex = 13;
            uLine6.Text = "uLine5";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("黑体", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.SkyBlue;
            lblTitle.Location = new Point(31, 222);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 22);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "实时曲线图";
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chart1.BackColor = Color.FromArgb(25, 55, 87);
            chart1.BorderlineColor = Color.LightSlateGray;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.LabelStyle.ForeColor = Color.LightGray;
            chartArea1.AxisX.LabelStyle.Format = "yyyy-MM-dd HH:mm:ss";
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.LineColor = Color.LightSlateGray;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = Color.Gray;
            chartArea1.AxisX.Title = "采集时间";
            chartArea1.AxisX.TitleAlignment = StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisX.TitleForeColor = Color.White;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.ForeColor = Color.LightGray;
            chartArea1.AxisY.LineColor = Color.LightSlateGray;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightSlateGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorTickMark.LineColor = Color.Gray;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MaximumAutoSize = 60F;
            chartArea1.AxisY.Title = "实时值";
            chartArea1.AxisY.TitleAlignment = StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chartArea1.AxisY.TitleForeColor = Color.White;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BorderColor = Color.LightSlateGray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 88F;
            chartArea1.InnerPlotPosition.Width = 92F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.InnerPlotPosition.Y = 3F;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 92F;
            chartArea1.Position.Width = 88F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.BorderColor = Color.SlateGray;
            legend1.BorderWidth = 0;
            legend1.ForeColor = Color.FromArgb(224, 224, 224);
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 17F;
            legend1.Position.Width = 9F;
            legend1.Position.X = 90F;
            legend1.Position.Y = 3F;
            legend1.Title = "数据曲线图";
            legend1.TitleForeColor = Color.SkyBlue;
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickGradientLine;
            legend1.TitleSeparatorColor = Color.SkyBlue;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(15, 268);
            chart1.Margin = new Padding(4, 4, 4, 4);
            chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = Color.FromArgb(255, 128, 0);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = Color.Turquoise;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = Color.DodgerBlue;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(1578, 644);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // FrmTrends
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1607, 926);
            Controls.Add(chart1);
            Controls.Add(uLine6);
            Controls.Add(lblTitle);
            Controls.Add(uGroupPanel21);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmTrends";
            Text = "FrmTrends";
            uGroupPanel21.ResumeLayout(false);
            uGroupPanel21.PerformLayout();
            panelAlarmStates.ResumeLayout(false);
            panelAlarmStates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel2 uGroupPanel21;
        private Zhaoxi.CustControls.UButton btnUpdate;
        private DateTimePicker dtEndTime;
        private DateTimePicker dtStartTime;
        private Panel panelAlarmStates;
        private NumericUpDown valCount;
        private CheckBox chk_B;
        private CheckBox chk_H;
        private CheckBox chk_T;
        private Label label3;
        private RadioButton rbtnHistoryTrends;
        private RadioButton rbtnRealTrends;
        private Label label6;
        private Label label5;
        private Label label2;
        private Zhaoxi.CustControls.UButton btnHistoryFind;
        private Label label1;
        private Zhaoxi.CustControls.ULine uLine2;
        private Zhaoxi.CustControls.ULine uLine1;
        private Zhaoxi.CustControls.ULine uLine6;
        private Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}