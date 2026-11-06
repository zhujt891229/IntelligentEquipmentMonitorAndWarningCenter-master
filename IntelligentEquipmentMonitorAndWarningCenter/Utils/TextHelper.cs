using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    //文本文件读写辅助类 
    public class TextHelper
    {
        //读取多行文本的操作
        public static List<string> ReadTextAllLines(string filepath)
        {
            List<string> lines = new List<string>();
            if (File.Exists(filepath))
            {
                lines = File.ReadLines(filepath).ToList();
            }
            return lines;
        }

        //一次性写入多行的操作
        //bool blAppend：传入的参数，决定写入模式。如果为 true，表示追加内容到文件末尾；如果为 false，表示覆盖原文件内容。
        public static void WriteMsgList(List<string> lines, string filePath, bool blAppend)
        {
            //using 关键字包裹，这是一个非常关键的写法。它能确保在代码块执行完毕后，
            //无论是否发生异常，StreamWriter 对象都会被自动关闭并释放底层文件资源
            //（即自动调用 Dispose 方法），防止文件被占用或内存泄漏。
            using (StreamWriter sw = new StreamWriter(filePath, blAppend))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
        }
        //写入一行
        public static void WriteMsg(string line, string filePath, bool blAppend)
        {
            //如果文件存在追加，如果不存在创建新的实例然后写入
            using (StreamWriter sw = new StreamWriter(filePath, blAppend))
            {
                sw.WriteLine(line);
            }
        }
    }
}
