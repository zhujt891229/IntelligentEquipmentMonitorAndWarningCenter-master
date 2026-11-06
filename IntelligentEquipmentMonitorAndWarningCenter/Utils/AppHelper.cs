using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    //app.Config 文件的读写
    public class AppHelper
    {
        //获取可执行方法的路径(运行时配置文件的完整文件名)
        static string path = (Assembly.GetExecutingAssembly()).GetName().Name+ ".dll.config";
        //获取appSetings 节点中指定键的值
        public static string GetValue(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("appSettings");
            if (node != null)
            {
                XmlElement addEle = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
                if (addEle != null)
                {
                    return addEle.GetAttribute("value");
                }
            }
            return "";
        }

        //在AppSetting节点中将指定的键写入指定的值
        public static void SetValue(string key, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("appSettings");
            //如果节点为null 则添加节点值
            if (node == null) {
                node = doc.CreateElement("appSettings");
                root.AppendChild(node);
            }
            if (node != null)
            {
                XmlElement addEle = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
                if (addEle != null)
                {
                    addEle.SetAttribute("value", value);

                }
                else
                {
                    addEle = doc.CreateElement("add");
                    addEle.SetAttribute("key", key);
                    addEle.SetAttribute("value", value);
                    node.AppendChild(addEle);
                }
            }
            doc.Save(path);
            return ;
        }

        public static string GetConnString(string key)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("connectionStrings");
            if (node != null)
            {
                XmlElement addEle = (XmlElement)node.SelectSingleNode("//add[@name='" + key + "']");
                if (addEle != null)
                {
                    return addEle.GetAttribute("connectionString");
                }

            }
            return "";
        }

        public static void SetConnString(string key, string connString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode node = root.SelectSingleNode("connectionStrings");
            if (node == null)
            {
                //添加appSetings节点
                node = doc.CreateElement("connectionStrings");
                root.AppendChild(node);
            }
            if (node != null)
            {
                XmlElement addEle = (XmlElement)node.SelectSingleNode("//add[@name='" + key + "']");
                if (addEle != null)
                {
                    addEle.SetAttribute("connectionString", connString);
                }
                else
                {
                    addEle = doc.CreateElement("add");
                    addEle.SetAttribute("name", key);
                    addEle.SetAttribute("connectionString", connString);
                    node.AppendChild(addEle);
                }
            }
            doc.Save(path);
        }


    }
}
