namespace IntelligentEquipmentMonitorAndWarningCenter.UControls
{
    partial class UNavItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            picimg = new PictureBox();
            IbIHeader = new Label();
            panelItem = new Zhaoxi.CustControls.UPanel();
            ((System.ComponentModel.ISupportInitialize)picimg).BeginInit();
            panelItem.SuspendLayout();
            SuspendLayout();
            // 
            // picimg
            // 
            picimg.BackColor = Color.Transparent;
            picimg.Image = Properties.Resources.xitongpeizhi;
            picimg.Location = new Point(14, 13);
            picimg.Name = "picimg";
            picimg.Size = new Size(30, 36);
            picimg.SizeMode = PictureBoxSizeMode.Zoom;
            picimg.TabIndex = 0;
            picimg.TabStop = false;
            picimg.Click += panelItem_Click;
            // 
            // IbIHeader
            // 
            IbIHeader.BackColor = Color.Transparent;
            IbIHeader.ForeColor = Color.White;
            IbIHeader.Location = new Point(50, 13);
            IbIHeader.Name = "IbIHeader";
            IbIHeader.Size = new Size(102, 36);
            IbIHeader.TabIndex = 1;
            IbIHeader.Text = "系统配置";
            IbIHeader.TextAlign = ContentAlignment.MiddleLeft;
            IbIHeader.Click += panelItem_Click;
            // 
            // panelItem
            // 
            panelItem.BgColor = Color.FromArgb(79, 121, 150);
            panelItem.Controls.Add(IbIHeader);
            panelItem.Controls.Add(picimg);
            panelItem.Dock = DockStyle.Fill;
            panelItem.Location = new Point(0, 0);
            panelItem.Name = "panelItem";
            panelItem.Radius = 0;
            panelItem.Size = new Size(200, 60);
            panelItem.TabIndex = 0;
            panelItem.Click += panelItem_Click;
            // 
            // UNavItem
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(panelItem);
            Name = "UNavItem";
            Size = new Size(200, 60);
            ((System.ComponentModel.ISupportInitialize)picimg).EndInit();
            panelItem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picimg;
        private Label IbIHeader;
        private Zhaoxi.CustControls.UPanel panelItem;
    }
}
