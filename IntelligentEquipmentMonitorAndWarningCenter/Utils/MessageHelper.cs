using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class MessageHelper
    {
        //传参数，默认先传标题，然后传内容
        //显示成功的提示
        public static void Success(string title,string message)
        {
            MessageBox.Show(message, title,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //显示失败的提示
        public static void Error(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // 显示警告的提示 
        public static void Warning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //显示询问的一个提示信息
        public static DialogResult Confirm(string title, string message)
        {
           return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
