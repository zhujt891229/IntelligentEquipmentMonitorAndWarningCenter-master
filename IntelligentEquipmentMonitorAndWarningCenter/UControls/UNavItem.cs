using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelligentEquipmentMonitorAndWarningCenter.UControls
{
    public partial class UNavItem : UserControl
    {
        public UNavItem()
        {
            InitializeComponent();
        }

        // 设置背景色1 
        private Color bgColor = Color.FromArgb(79, 121, 150);
        [DefaultValue(typeof(Color), "0xFF4F7996"), Description("背景色1"), Category("自定义")]
        public Color BgColor
        {
            get { return bgColor; }
            set
            {
                bgColor = value;
                if (panelItem != null)
                {
                    panelItem.BgColor = bgColor;
                    this.Invalidate();
                }
            }
        }

        // 设置背景色2 
        [DefaultValue(typeof(Color), "Transparent"), Description("背景色2"), Category("自定义")]
        public Color BgColor2
        {
            get { return panelItem != null ? panelItem.BgColor2 : Color.Transparent; }
            set
            {
                if (panelItem != null)
                {
                    panelItem.BgColor2 = value;
                    this.Invalidate();
                }
            }
        }

        //选择后的背景
        private Color selectedColor = Color.FromArgb(54, 98, 100);
        [DefaultValue(typeof(Color), "0xFF366264"), Description("选中状态背景色"), Category("自定义")]
        public Color SelectedColor
        {
            get { return selectedColor; }
            set
            {
                selectedColor = value;
                this.Invalidate();
            }
        }

        //设置背景色渐变方向
        [DefaultValue(LinearGradientMode.Vertical), Description("背景色渐变方向"), Category("自定义")]
        public LinearGradientMode GradientMode
        {
            get { return panelItem != null ? panelItem.GradientMode : LinearGradientMode.Vertical; }
            set
            {
                if (panelItem != null)
                {
                    panelItem.GradientMode = value;
                    this.Invalidate();
                }
            }
        }

        //导航标题
        [DefaultValue("导航标题"), Description("导航项的标题"), Category("自定义")]
        public string Header
        {
            get { return IbIHeader != null ? IbIHeader.Text : ""; }
            set
            {
                if (IbIHeader != null)
                {
                    IbIHeader.Text = value;
                }
            }
        }

        //普通图标
        private Image oldIcon;
        [Description("普通状态图标"), Category("自定义")]
        public Image Icon
        {
            get { return oldIcon; }
            set
            {
                oldIcon = value;
                if (picimg != null)
                {
                    picimg.Image = oldIcon;
                }
            }
        }

        //选中图标
        private Image selIcon;
        [Description("选中状态图标"), Category("自定义")]
        public Image SelIcon
        {
            get { return selIcon; }
            set { selIcon = value; }
        }

        //导航标题文字颜色
        [Description("导航标题文字颜色"), Category("自定义")]
        public Color HeadColor
        {
            get { return IbIHeader != null ? IbIHeader.ForeColor : Color.White; }
            set
            {
                if (IbIHeader != null)
                {
                    IbIHeader.ForeColor = value;
                }
            }
        }

        //导航标题字体
        [Description("导航标题字体"), Category("自定义")]
        public Font HeaderFont
        {
            get { return IbIHeader != null ? IbIHeader.Font : base.Font; }
            set
            {
                if (IbIHeader != null)
                {
                    IbIHeader.Font = value;
                }
            }
        }

        public event EventHandler Navigate;
        private void panelItem_Click(object sender, EventArgs e)
        {
            SelectNavItem();
            //引发事件
            Navigate?.Invoke(this, EventArgs.Empty);
        }

        // 选择后导航项的处理结果
        public void SelectNavItem()
        {
            // 拿到当前的父容器
           var parent = this.Parent;
           if(parent != null) 
                foreach (Control c in parent.Controls) { 
                    if(c is UNavItem) {
                        UNavItem item = (UNavItem)c;
                        if (item.Header == this.Header) {
                            item.HeadColor = Color.Cyan;
                            item.BgColor2 = selectedColor;
                            picimg.Image = selIcon;
                        }
                        else
                        {
                            item.HeadColor = Color.White;
                            item.BgColor2 = Color.Transparent;
                            item.Icon = item.oldIcon;
                        }
                }
           }
        }
    }
}
