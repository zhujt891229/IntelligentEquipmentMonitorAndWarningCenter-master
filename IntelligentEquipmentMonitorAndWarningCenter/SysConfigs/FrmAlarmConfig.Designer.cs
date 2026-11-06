namespace IntelligentDeviceMonitorAndWarningCenter.SysConfigs
{
    partial class FrmAlarmConfig
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
            uGroupPanel = new Zhaoxi.CustControls.UGroupPanel3();
            valMax_B = new NumericUpDown();
            valMax_H = new NumericUpDown();
            valMax_T = new NumericUpDown();
            valMin_B = new NumericUpDown();
            valMin_H = new NumericUpDown();
            valMin_T = new NumericUpDown();
            lblMsg = new Label();
            btnOK = new Zhaoxi.CustControls.UButton();
            label4 = new Label();
            txtGrade_H_B = new TextBox();
            txtGrade_H_H = new TextBox();
            txtGrade_H_T = new TextBox();
            label3 = new Label();
            txtGrade_M_B = new TextBox();
            txtGrade_M_H = new TextBox();
            txtGrade_M_T = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            txtGrade_L_B = new TextBox();
            txtGrade_L_H = new TextBox();
            txtGrade_L_T = new TextBox();
            label14 = new Label();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            label6 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            uGroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)valMax_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valMax_H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valMax_T).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valMin_B).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valMin_H).BeginInit();
            ((System.ComponentModel.ISupportInitialize)valMin_T).BeginInit();
            SuspendLayout();
            // 
            // uGroupPanel
            // 
            uGroupPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uGroupPanel.Background = Color.FromArgb(25, 55, 87);
            uGroupPanel.Controls.Add(valMax_B);
            uGroupPanel.Controls.Add(valMax_H);
            uGroupPanel.Controls.Add(valMax_T);
            uGroupPanel.Controls.Add(valMin_B);
            uGroupPanel.Controls.Add(valMin_H);
            uGroupPanel.Controls.Add(valMin_T);
            uGroupPanel.Controls.Add(lblMsg);
            uGroupPanel.Controls.Add(btnOK);
            uGroupPanel.Controls.Add(label4);
            uGroupPanel.Controls.Add(txtGrade_H_B);
            uGroupPanel.Controls.Add(txtGrade_H_H);
            uGroupPanel.Controls.Add(txtGrade_H_T);
            uGroupPanel.Controls.Add(label3);
            uGroupPanel.Controls.Add(txtGrade_M_B);
            uGroupPanel.Controls.Add(txtGrade_M_H);
            uGroupPanel.Controls.Add(txtGrade_M_T);
            uGroupPanel.Controls.Add(label7);
            uGroupPanel.Controls.Add(label5);
            uGroupPanel.Controls.Add(label2);
            uGroupPanel.Controls.Add(txtGrade_L_B);
            uGroupPanel.Controls.Add(txtGrade_L_H);
            uGroupPanel.Controls.Add(txtGrade_L_T);
            uGroupPanel.Controls.Add(label14);
            uGroupPanel.Controls.Add(label8);
            uGroupPanel.Controls.Add(label12);
            uGroupPanel.Controls.Add(label13);
            uGroupPanel.Controls.Add(label6);
            uGroupPanel.Controls.Add(label11);
            uGroupPanel.Controls.Add(label10);
            uGroupPanel.Controls.Add(label9);
            uGroupPanel.Controls.Add(label1);
            uGroupPanel.CornerRadius = 5;
            uGroupPanel.Font = new Font("黑体", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uGroupPanel.Location = new Point(15, 14);
            uGroupPanel.Margin = new Padding(4);
            uGroupPanel.Name = "uGroupPanel";
            uGroupPanel.Padding = new Padding(4);
            uGroupPanel.PrimaryColor = Color.White;
            uGroupPanel.Size = new Size(1508, 806);
            uGroupPanel.TabIndex = 1;
            uGroupPanel.TabStop = false;
            uGroupPanel.Text = "预警配置";
            // 
            // valMax_B
            // 
            valMax_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMax_B.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            valMax_B.Location = new Point(502, 270);
            valMax_B.Margin = new Padding(4);
            valMax_B.Name = "valMax_B";
            valMax_B.Size = new Size(122, 31);
            valMax_B.TabIndex = 8;
            valMax_B.Value = new decimal(new int[] { 75, 0, 0, 0 });
            // 
            // valMax_H
            // 
            valMax_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMax_H.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            valMax_H.Location = new Point(502, 204);
            valMax_H.Margin = new Padding(4);
            valMax_H.Name = "valMax_H";
            valMax_H.Size = new Size(122, 31);
            valMax_H.TabIndex = 8;
            valMax_H.Value = new decimal(new int[] { 65, 0, 0, 0 });
            // 
            // valMax_T
            // 
            valMax_T.DecimalPlaces = 1;
            valMax_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMax_T.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            valMax_T.Location = new Point(502, 142);
            valMax_T.Margin = new Padding(4);
            valMax_T.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            valMax_T.Name = "valMax_T";
            valMax_T.Size = new Size(122, 31);
            valMax_T.TabIndex = 8;
            valMax_T.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // valMin_B
            // 
            valMin_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMin_B.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            valMin_B.Location = new Point(291, 270);
            valMin_B.Margin = new Padding(4);
            valMin_B.Name = "valMin_B";
            valMin_B.Size = new Size(122, 31);
            valMin_B.TabIndex = 8;
            valMin_B.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // valMin_H
            // 
            valMin_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMin_H.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            valMin_H.Location = new Point(291, 204);
            valMin_H.Margin = new Padding(4);
            valMin_H.Name = "valMin_H";
            valMin_H.Size = new Size(122, 31);
            valMin_H.TabIndex = 8;
            valMin_H.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // valMin_T
            // 
            valMin_T.DecimalPlaces = 1;
            valMin_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            valMin_T.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            valMin_T.Location = new Point(291, 142);
            valMin_T.Margin = new Padding(4);
            valMin_T.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            valMin_T.Name = "valMin_T";
            valMin_T.Size = new Size(122, 31);
            valMin_T.TabIndex = 8;
            valMin_T.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("微软雅黑", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Orange;
            lblMsg.Location = new Point(304, 703);
            lblMsg.Margin = new Padding(4, 0, 4, 0);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(554, 90);
            lblMsg.TabIndex = 5;
            lblMsg.Text = "设置成功！";
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
            btnOK.Location = new Point(291, 624);
            btnOK.Margin = new Padding(4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(143, 48);
            btnOK.TabIndex = 3;
            btnOK.Text = "确定";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(178, 408);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 1;
            label4.Text = "温度等级：";
            // 
            // txtGrade_H_B
            // 
            txtGrade_H_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_H_B.Location = new Point(717, 539);
            txtGrade_H_B.Margin = new Padding(4);
            txtGrade_H_B.Name = "txtGrade_H_B";
            txtGrade_H_B.Size = new Size(158, 31);
            txtGrade_H_B.TabIndex = 2;
            txtGrade_H_B.Text = "耀眼";
            txtGrade_H_B.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_H_H
            // 
            txtGrade_H_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_H_H.Location = new Point(716, 474);
            txtGrade_H_H.Margin = new Padding(4);
            txtGrade_H_H.Name = "txtGrade_H_H";
            txtGrade_H_H.Size = new Size(158, 31);
            txtGrade_H_H.TabIndex = 2;
            txtGrade_H_H.Text = "潮湿";
            txtGrade_H_H.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_H_T
            // 
            txtGrade_H_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_H_T.Location = new Point(716, 403);
            txtGrade_H_T.Margin = new Padding(4);
            txtGrade_H_T.Name = "txtGrade_H_T";
            txtGrade_H_T.Size = new Size(158, 31);
            txtGrade_H_T.TabIndex = 2;
            txtGrade_H_T.Text = "炎热";
            txtGrade_H_T.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(142, 274);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 25);
            label3.TabIndex = 1;
            label3.Text = "亮度阈值范围：";
            // 
            // txtGrade_M_B
            // 
            txtGrade_M_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_M_B.Location = new Point(499, 539);
            txtGrade_M_B.Margin = new Padding(4);
            txtGrade_M_B.Name = "txtGrade_M_B";
            txtGrade_M_B.Size = new Size(158, 31);
            txtGrade_M_B.TabIndex = 2;
            txtGrade_M_B.Text = "适中";
            txtGrade_M_B.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_M_H
            // 
            txtGrade_M_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_M_H.Location = new Point(497, 474);
            txtGrade_M_H.Margin = new Padding(4);
            txtGrade_M_H.Name = "txtGrade_M_H";
            txtGrade_M_H.Size = new Size(158, 31);
            txtGrade_M_H.TabIndex = 2;
            txtGrade_M_H.Text = "舒适";
            txtGrade_M_H.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_M_T
            // 
            txtGrade_M_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_M_T.Location = new Point(497, 403);
            txtGrade_M_T.Margin = new Padding(4);
            txtGrade_M_T.Name = "txtGrade_M_T";
            txtGrade_M_T.Size = new Size(158, 31);
            txtGrade_M_T.TabIndex = 2;
            txtGrade_M_T.Text = "舒适";
            txtGrade_M_T.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(180, 544);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 1;
            label7.Text = "亮度等级：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(178, 478);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 1;
            label5.Text = "湿度等级：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(142, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 1;
            label2.Text = "湿度阈值范围：";
            // 
            // txtGrade_L_B
            // 
            txtGrade_L_B.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_L_B.Location = new Point(291, 539);
            txtGrade_L_B.Margin = new Padding(4);
            txtGrade_L_B.Name = "txtGrade_L_B";
            txtGrade_L_B.Size = new Size(158, 31);
            txtGrade_L_B.TabIndex = 2;
            txtGrade_L_B.Text = "昏暗";
            txtGrade_L_B.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_L_H
            // 
            txtGrade_L_H.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_L_H.Location = new Point(290, 474);
            txtGrade_L_H.Margin = new Padding(4);
            txtGrade_L_H.Name = "txtGrade_L_H";
            txtGrade_L_H.Size = new Size(158, 31);
            txtGrade_L_H.TabIndex = 2;
            txtGrade_L_H.Text = "干燥";
            txtGrade_L_H.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGrade_L_T
            // 
            txtGrade_L_T.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtGrade_L_T.Location = new Point(290, 403);
            txtGrade_L_T.Margin = new Padding(4);
            txtGrade_L_T.Name = "txtGrade_L_T";
            txtGrade_L_T.Size = new Size(158, 31);
            txtGrade_L_T.TabIndex = 2;
            txtGrade_L_T.Text = "低温";
            txtGrade_L_T.TextAlign = HorizontalAlignment.Center;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label14.ForeColor = Color.Silver;
            label14.Location = new Point(642, 277);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(71, 25);
            label14.TabIndex = 1;
            label14.Text = "cd/m2";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label8.ForeColor = Color.LightSlateGray;
            label8.Location = new Point(108, 350);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(120, 25);
            label8.TabIndex = 1;
            label8.Text = "等级名称设置";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(642, 211);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(29, 25);
            label12.TabIndex = 1;
            label12.Text = "%";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(445, 277);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(26, 25);
            label13.TabIndex = 1;
            label13.Text = "~";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label6.ForeColor = Color.LightSlateGray;
            label6.Location = new Point(108, 89);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(192, 25);
            label6.TabIndex = 1;
            label6.Text = "实时数据预警范围设置";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(445, 211);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(26, 25);
            label11.TabIndex = 1;
            label11.Text = "~";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(642, 149);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(30, 25);
            label10.TabIndex = 1;
            label10.Text = "℃";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(445, 149);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(26, 25);
            label9.TabIndex = 1;
            label9.Text = "~";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(142, 145);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "温度阈值范围：";
            // 
            // FrmAlarmConfig
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1538, 835);
            Controls.Add(uGroupPanel);
            Margin = new Padding(4);
            Name = "FrmAlarmConfig";
            Text = "预警配置";
            Load += FrmAlarmConfig_Load;
            VisibleChanged += FrmAlarmConfig_VisibleChanged;
            uGroupPanel.ResumeLayout(false);
            uGroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)valMax_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)valMax_H).EndInit();
            ((System.ComponentModel.ISupportInitialize)valMax_T).EndInit();
            ((System.ComponentModel.ISupportInitialize)valMin_B).EndInit();
            ((System.ComponentModel.ISupportInitialize)valMin_H).EndInit();
            ((System.ComponentModel.ISupportInitialize)valMin_T).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Zhaoxi.CustControls.UGroupPanel3 uGroupPanel;
        private Label lblMsg;
        private Zhaoxi.CustControls.UButton btnOK;
        private Label label4;
        private TextBox txtGrade_H_T;
        private Label label3;
        private TextBox txtGrade_M_T;
        private Label label5;
        private Label label2;
        private TextBox txtGrade_L_T;
        private Label label6;
        private Label label1;
        private TextBox txtGrade_H_B;
        private TextBox txtGrade_H_H;
        private TextBox txtGrade_M_B;
        private TextBox txtGrade_M_H;
        private Label label7;
        private TextBox txtGrade_L_B;
        private TextBox txtGrade_L_H;
        private Label label8;
        private NumericUpDown valMax_T;
        private NumericUpDown valMin_T;
        private Label label10;
        private Label label9;
        private NumericUpDown valMax_B;
        private NumericUpDown valMax_H;
        private NumericUpDown valMin_B;
        private NumericUpDown valMin_H;
        private Label label14;
        private Label label12;
        private Label label13;
        private Label label11;
    }
}