using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public static class Utility
    {
        //展示子页面
        public static void ShowChildPage<F>(Panel panel) where F : Form, new()
        {
            //用来判断当前组件是不是Form 是的话就显示
            bool bl = false;
            foreach (Control c in panel.Controls) {
                Form form = c as Form;
                if (form.GetType() == typeof(F)) { 
                    bl = true;
                    form.Show();
                }
                else
                {
                    form.Hide();
                }
            }
            if (!bl)
            {
                F frm = new F();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.WindowState = FormWindowState.Maximized;
                panel.Controls.Add(frm);
                frm.Show();
            }
        }

        //子页面自适应窗体大小
        public static void panelPage_SizeChanged(object sender)
        {
            Panel panel = (Panel)sender;
            foreach (Control c in panel.Controls)
            {
                Form frm = c as Form;
                frm.WindowState = FormWindowState.Normal;
                frm.SuspendLayout();
                frm.Size = panel.Size;
                frm.ResumeLayout(true);
                frm.WindowState = FormWindowState.Maximized;
            }
        }

        //设置消息设置成功或者失败提醒
        public static void SetMsg(this Label label,string msg,Color color)
        {
            label.Text = msg;
            label.Visible = true;
            label.ForeColor = color;
        }

        public static void SetErrmsg(this Label label ,string msg)
        {
            //显示错误消息
            label.SetMsg(msg,Color.Red);
        }
        public static void SetSuccmsg(this Label label, string msg)
        {
            //显示成功的消息
            label.SetMsg(msg, Color.Orange);
            //成功之后过一会隐藏
            Task.Run(() => {
                Thread.Sleep(1000);
                label.Invoke(() =>
                {
                    //label.Visible = false;
                    label.Hide();
                });
            });
        }



    }
}
