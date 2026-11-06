namespace IntelligentEquipmentMonitorAndWarningCenter
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            uPanel1 = new Zhaoxi.CustControls.UPanel();
            lblMsg = new Label();
            btnLogin = new Zhaoxi.CustControls.UButton();
            uPanel3 = new Zhaoxi.CustControls.UPanel();
            txtUserPwd = new TextBox();
            pictureBox6 = new PictureBox();
            uPanel2 = new Zhaoxi.CustControls.UPanel();
            txtUserName = new TextBox();
            pictureBox5 = new PictureBox();
            label3 = new Label();
            uLine1 = new Zhaoxi.CustControls.ULine();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            uPanel1.SuspendLayout();
            uPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            uPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 16, 34);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Webdings", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 2);
            btnClose.ImageAlign = ContentAlignment.BottomCenter;
            btnClose.Location = new Point(1215, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(55, 36);
            btnClose.TabIndex = 0;
            btnClose.Text = "r";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // uPanel1
            // 
            uPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uPanel1.BgColor = Color.White;
            uPanel1.Controls.Add(lblMsg);
            uPanel1.Controls.Add(btnLogin);
            uPanel1.Controls.Add(uPanel3);
            uPanel1.Controls.Add(uPanel2);
            uPanel1.Controls.Add(label3);
            uPanel1.Controls.Add(uLine1);
            uPanel1.Controls.Add(pictureBox4);
            uPanel1.Controls.Add(pictureBox3);
            uPanel1.Controls.Add(pictureBox2);
            uPanel1.Controls.Add(pictureBox1);
            uPanel1.Controls.Add(label2);
            uPanel1.Controls.Add(label1);
            uPanel1.Location = new Point(180, 74);
            uPanel1.Name = "uPanel1";
            uPanel1.Radius = 10;
            uPanel1.Size = new Size(905, 501);
            uPanel1.TabIndex = 1;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.White;
            lblMsg.Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(545, 377);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(325, 105);
            lblMsg.TabIndex = 11;
            lblMsg.Text = "请输入账号和密码！";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BgColor = Color.Orange;
            btnLogin.BorderColor = Color.Peru;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FocusBgColor = Color.DarkOrange;
            btnLogin.FocusForeColor = Color.White;
            btnLogin.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnLogin.Location = new Point(577, 305);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 50;
            btnLogin.Size = new Size(219, 59);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "登录系统";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // uPanel3
            // 
            uPanel3.BackColor = Color.White;
            uPanel3.BgColor = Color.White;
            uPanel3.BorderColor = Color.LightGray;
            uPanel3.BorderWidth = 1;
            uPanel3.Controls.Add(txtUserPwd);
            uPanel3.Controls.Add(pictureBox6);
            uPanel3.Location = new Point(552, 219);
            uPanel3.Name = "uPanel3";
            uPanel3.Size = new Size(289, 55);
            uPanel3.TabIndex = 9;
            // 
            // txtUserPwd
            // 
            txtUserPwd.BorderStyle = BorderStyle.None;
            txtUserPwd.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUserPwd.ForeColor = Color.FromArgb(64, 64, 64);
            txtUserPwd.Location = new Point(58, 12);
            txtUserPwd.Name = "txtUserPwd";
            txtUserPwd.Size = new Size(225, 27);
            txtUserPwd.TabIndex = 2;
            txtUserPwd.Text = "123456";
            txtUserPwd.UseSystemPasswordChar = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.mima;
            pictureBox6.Location = new Point(3, 10);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // uPanel2
            // 
            uPanel2.BackColor = Color.White;
            uPanel2.BgColor = Color.White;
            uPanel2.BorderColor = Color.LightGray;
            uPanel2.BorderWidth = 1;
            uPanel2.Controls.Add(txtUserName);
            uPanel2.Controls.Add(pictureBox5);
            uPanel2.Location = new Point(552, 141);
            uPanel2.Name = "uPanel2";
            uPanel2.Size = new Size(289, 55);
            uPanel2.TabIndex = 8;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtUserName.ForeColor = Color.FromArgb(64, 64, 64);
            txtUserName.Location = new Point(58, 11);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(225, 27);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "admin";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.zhanghao;
            pictureBox5.Location = new Point(3, 10);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("微软雅黑", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(24, 369);
            label3.Name = "label3";
            label3.Size = new Size(327, 28);
            label3.TabIndex = 7;
            label3.Text = "集检测，控制，预警，统计于一体";
            // 
            // uLine1
            // 
            uLine1.BackColor = Color.Transparent;
            uLine1.LineColor = Color.Black;
            uLine1.LineWidth = 2;
            uLine1.Location = new Point(24, 339);
            uLine1.Name = "uLine1";
            uLine1.Size = new Size(385, 10);
            uLine1.TabIndex = 6;
            uLine1.Text = "uLine1";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = Properties.Resources.dev02;
            pictureBox4.Location = new Point(295, 236);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 85);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources.dev02;
            pictureBox3.Location = new Point(149, 236);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.dev02;
            pictureBox2.Location = new Point(3, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 85);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.dev01;
            pictureBox1.Location = new Point(91, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("微软雅黑", 16F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.ForeColor = Color.FromArgb(53, 87, 117);
            label2.Location = new Point(604, 77);
            label2.Name = "label2";
            label2.Size = new Size(146, 42);
            label2.TabIndex = 1;
            label2.Text = "系统登录";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.ForeColor = Color.FromArgb(53, 87, 117);
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(308, 47);
            label1.TabIndex = 0;
            label1.Text = "智能设备检测预警";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 55, 87);
            ClientSize = new Size(1269, 641);
            Controls.Add(uPanel1);
            Controls.Add(btnClose);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Text = " 登录系统";
            Load += FrmLogin_Load;
            uPanel1.ResumeLayout(false);
            uPanel1.PerformLayout();
            uPanel3.ResumeLayout(false);
            uPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            uPanel2.ResumeLayout(false);
            uPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Zhaoxi.CustControls.UPanel uPanel1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Zhaoxi.CustControls.ULine uLine1;
        private PictureBox pictureBox4;
        private Zhaoxi.CustControls.UPanel uPanel3;
        private PictureBox pictureBox6;
        private Zhaoxi.CustControls.UPanel uPanel2;
        private TextBox txtUserName;
        private PictureBox pictureBox5;
        private Zhaoxi.CustControls.UButton btnLogin;
        private TextBox txtUserPwd;
        private Label lblMsg;
    }
}
