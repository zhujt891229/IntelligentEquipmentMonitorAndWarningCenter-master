using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Common;
using IntelligentEquipmentMonitorAndWarningCenter.Models;
using Newtonsoft.Json;
using Zhaoxi.IntelligentDeviceMonitorAndWarningCenter.Models;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class FileConvert
    {
        //从文本中读取通信配置信息
        public static Dictionary<string, string> ReadCommunicateSetFromTxt(string filename)
        {
            Dictionary<string, string> sets = new Dictionary<string, string>();
            var lines = File.ReadAllLines(filename);
            if (lines.Count() > 0)
            {
                foreach (var line in lines)
                {
                    string[] arr = line.Split('：');
                    string key = arr[0];
                    string value = arr[1];
                    sets.Add(key, value);
                }
            }
            return sets;
        }
        public static Dictionary<string, string> ReadCommunicateSetFromXML(string xmlPath)
        {
            Dictionary<string, string> sets = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlPath);
            var root = doc.DocumentElement; //根元素
            foreach (XmlNode node in root.ChildNodes)
            {
                string key = node.Name;
                string val = node.InnerText;
                sets.Add(key, val);
            }
            return sets;
        }
        //把 Set 中的内容解析成xml 格式的文件
        public static void WriteCommunicateSetToXML(string xmlPath, Dictionary<string, string> sets)
        {
            XmlDocument doc = new XmlDocument();
            var root = doc.CreateElement("CommunicateSet");
            foreach (KeyValuePair<string, string> kvp in sets)
            {
                var ele = doc.CreateElement(kvp.Key);     // Key 作为标签名
                ele.InnerText = kvp.Value;                // Value 作为内容
                root.AppendChild(ele);
            }
            doc.AppendChild(root);
            doc.Save(xmlPath);
        }

        public static void WriteCommunicateSetToTxt(string txtPath, Dictionary<string, string> sets)
        {
            List<string> list = new List<string>();
            foreach (string key in sets.Keys)
            {
                string val = sets[key];
                list.Add($"{key}：{val}");
            }
            TextHelper.WriteMsgList(list, txtPath, false); //写入到文件中
        }

        //将txt 转换成 xml
        public static void CommunicationSetTxtToXML(string txtPath, string xmlPath)
        {
            //从txt 获得数据
            var sets = ReadCommunicateSetFromTxt(txtPath);
            // 将txt 文件中的数据 写入到xml 文档中 
            WriteCommunicateSetToXML(xmlPath, sets);
        }

        //将 xml 转换成txt 
        public static void CommunicationSetXMLToTxt(string xmlPath, string txtPath)
        {
            // 从xml 文件中读取内容
            var sets = ReadCommunicateSetFromXML(xmlPath);
            //将读写内容写入到txt 文档中
            WriteCommunicateSetToTxt(txtPath, sets);
        }

        //加载通信配置文件中的通信连接信息
        public static void LoadCommunicateSets()
        {
            if (CommonHelper.communicationFile != null)
            {
                string path = CommonHelper.communicationFile;
                //如果配置文件存在
                if (File.Exists(path))
                {
                    //读取配置
                    string ext = Path.GetExtension(path);
                    Dictionary<string, string> dic = new Dictionary<string, string>();
                    if (ext == ".txt")
                    {
                        dic = ReadCommunicateSetFromTxt(path);

                    }
                    else if (ext == ".xml")
                    {
                        dic = ReadCommunicateSetFromXML(path);
                    }
                    CommunicateSet comSet = new CommunicateSet();
                    comSet.BaudRate = dic["BaudRate"].GetInt();
                    comSet.Parity = Enum.Parse<Parity>(dic["Parity"]);
                    comSet.DataBits = dic["DataBits"].GetInt();
                    comSet.StopBits = Enum.Parse<StopBits>(dic["StopBits"]);
                    CommonHelper.communicateSet = comSet;

                }
            }
        }
        public static (Dictionary<string, string[]>, Dictionary<string, string>) ReadAlarmSetsFromTxt(string txtPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //读取文件中的多行文本
            var lines = TextHelper.ReadTextAllLines(txtPath);
            if (lines.Count > 0)
            {
                for (int i = 1; i < 10; i += 3)
                {
                    dicConditions.Add(lines[i], new string[] { lines[i + 1], lines[i + 2] });
                }
                for (int i = 11; i < lines.Count; i += 4)
                {
                    dicGrades.Add(lines[i], $"{lines[i + 1].Split('：')[1]},{lines[i + 2].Split('：')[1]},{lines[i + 3].Split('：')[1]}");
                }
            }
            return (dicConditions, dicGrades);
        }

        public static (Dictionary<string, string[]>, Dictionary<string, string>) ReadAlarmSetsFromXML(string xmlPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            XmlDocument doc = new XmlDocument();
            //加载xml文件
            doc.Load(xmlPath);
            //获取根
            var root = doc.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                string type = node.Attributes["Type"].Value;
                if (node.Name == "Condition")
                {
                    string unit = node.Attributes["Unit"].Value;
                    string str1 = "下限阈值：" + node.SelectSingleNode("Min").InnerText + " " + unit;
                    string str2 = "上限阈值：" + node.SelectSingleNode("Max").InnerText + " " + unit;
                    dicConditions.Add(type, new string[] { str1, str2 });
                }
                else if (node.Name == "Grade")
                {
                    string grade1 = node.SelectSingleNode("Grade1").InnerText;
                    string grade2 = node.SelectSingleNode("Grade2").InnerText;
                    string grade3 = node.SelectSingleNode("Grade3").InnerText;
                    dicGrades.Add(type, $"{grade1},{grade2},{grade3}");
                }
            }
            return (dicConditions, dicGrades);
        }

        /// <summary>
        /// 读取报警配置文件：从json文件中读取
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <returns></returns>
        public static (Dictionary<string, string[]>, Dictionary<string, string>) ReadAlarmSetsFromJson(string jsonPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //将json字符串读取
            string json = File.ReadAllText(jsonPath);
            //反序列化
            AlarmSetInfo alarmSet = JsonConvert.DeserializeObject<AlarmSetInfo>(json);
            if (alarmSet != null)
            {
                var conditions = alarmSet.Conditions;
                foreach (var condition in conditions)
                {
                    string unit = condition.Unit;//单位
                    string str1 = "下限阈值：" + condition.MinValue + " " + unit;
                    string str2 = "上限阈值：" + condition.MaxValue + " " + unit;
                    dicConditions.Add(condition.ConditionType,new string[] {str1, str2});
                }
                var grades = alarmSet.Grades;
                foreach (var grade in grades)
                {
                    dicGrades.Add(grade.GradeType,$"{grade.Grade1},{grade.Grade2},{grade.Grade3}");
                }
            }
            return (dicConditions, dicGrades);
        }

        public static void LoadAlarmSets()
        {
            string path = CommonHelper.alarmSetsFile;
            string ext = Path.GetExtension(path);//扩展名
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            switch (ext)
            {
                case ".txt":
                    (dicConditions, dicGrades) = ReadAlarmSetsFromTxt(path); break;
                case ".xml":
                    (dicConditions, dicGrades) = ReadAlarmSetsFromXML(path); break;
                case ".json":
                    (dicConditions, dicGrades) = ReadAlarmSetsFromJson(path); break;
            }
            AlarmSetInfo setInfo = ConvertToAlarmSet(dicConditions, dicGrades);
            CommonHelper.alarmsets = setInfo;
        }

        public static AlarmSetInfo ConvertToAlarmSet(Dictionary<string, string[]> dicConditions, Dictionary<string, string> dicGrades)
        {
            AlarmSetInfo alarmSet = new AlarmSetInfo();
            List<AlarmCondition> conditions = new List<AlarmCondition>();
            List<Grade> grades = new List<Grade>();
            foreach (string key in dicConditions.Keys)
            {
                AlarmCondition condition = new AlarmCondition();
                condition.ConditionType = key;
                string[] sets = dicConditions[key];
                string[] sets0 = sets[0].Split('：')[1].Split(' ');
                string[] sets1 = sets[1].Split('：')[1].Split(' ');
                condition.Unit = sets0[1];//单位
                condition.MinValue = sets0[0].GetDouble();
                condition.MaxValue = sets1[0].GetDouble();
                conditions.Add(condition);
            }
            foreach (string key in dicGrades.Keys)
            {
                Grade grade = new Grade();
                grade.GradeType = key;
                string[] names = dicGrades[key].Split(',');
                grade.Grade1 = names[0];
                grade.Grade2 = names[1];
                grade.Grade3 = names[2];
                grades.Add(grade);
            }
            alarmSet.Conditions = conditions;
            alarmSet.Grades = grades;
            return alarmSet;
        }
        /// <summary>
        /// 报警配置文件转换：由txt文件转换为xml文件
        /// </summary>
        /// <param name="txtPath">txt文件路径</param>
        /// <param name="xmlPath">xml文件路径</param>
        public static void AlarmSetsTxtToXML(string txtPath, string xmlPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从文本文件中读取设置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromTxt(txtPath);
            //写入到xml文件中
            WriteAlarmSetsToXML(xmlPath, dicConditions, dicGrades);
        }

        /// <summary>
        /// 报警配置文件转换：由txt文件转换为json文件
        /// </summary>
        /// <param name="txtPath">txt文件路径</param>
        /// <param name="jsonPath">json文件路径</param>
        public static void AlarmSetsTxtToJson(string txtPath, string jsonPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从文本文件中读取设置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromTxt(txtPath);
            //写入到json文件
            WriteAlarmSetsToJson(jsonPath, dicConditions, dicGrades);
        }

        /// <summary>
        ///  报警配置文件转换：由xml文件转换为txt文件
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="txtPath"></param>
        public static void AlarmSetsXMLToTxt(string xmlPath, string txtPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从xml文件中读取配置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromXML(xmlPath);
            //写入到txt文件中
            WriteAlarmSetsToTxt(txtPath, dicConditions, dicGrades);
        }

        /// <summary>
        ///  报警配置文件转换：由xml文件转换为json文件
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="jsonPath"></param>
        public static void AlarmSetsXMLToJson(string xmlPath, string jsonPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从xml文件中读取配置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromXML(xmlPath);
            //写入到json文件中
            WriteAlarmSetsToJson(jsonPath, dicConditions, dicGrades);
        }

        /// <summary>
        /// 报警配置文件转换：由json文件转换为txt文件
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <param name="txtPath"></param>
        public static void AlarmSetsJsonToTxt(string jsonPath, string txtPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从json文件中读取配置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromJson(jsonPath);
            //写入到txt文件中
            WriteAlarmSetsToTxt(txtPath, dicConditions, dicGrades);
        }

        /// <summary>
        /// 报警配置文件转换：由json文件转换为xml文件
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <param name="xmlPath"></param>
        public static void AlarmSetsJsonToXML(string jsonPath, string xmlPath)
        {
            //数据阈值范围
            Dictionary<string, string[]> dicConditions = new Dictionary<string, string[]>();
            //等级名称设置
            Dictionary<string, string> dicGrades = new Dictionary<string, string>();
            //从json文件中读取配置信息
            (dicConditions, dicGrades) = ReadAlarmSetsFromJson(jsonPath);
            //写入到xml文件中
            WriteAlarmSetsToXML(xmlPath, dicConditions, dicGrades);
        }


        /// <summary>
        /// 将报警配置信息写到XML文件中
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <param name="dicConditions"></param>
        /// <param name="dicGrades"></param>
        public static void WriteAlarmSetsToXML(string xmlPath, Dictionary<string, string[]> dicConditions, Dictionary<string, string> dicGrades)
        {
            XmlDocument doc = new XmlDocument();
            var root = doc.CreateElement("AlarmSets");//创建根元素
            foreach (KeyValuePair<string, string[]> kvp in dicConditions)
            {
                var ele = doc.CreateElement("Condition");
                ele.SetAttribute("Type", kvp.Key);//Type属性
                string[] sets = kvp.Value;
                ele.SetAttribute("Unit", sets[0].Split('：')[1].Split(' ')[1]);//Unit属性

                var childEle1 = doc.CreateElement("Min");
                childEle1.InnerText = sets[0].Split('：')[1].Split(' ')[0];
                ele.AppendChild(childEle1);

                var childEle2 = doc.CreateElement("Max");
                childEle2.InnerText = sets[1].Split('：')[1].Split(' ')[0];
                ele.AppendChild(childEle2);

                root.AppendChild(ele);
            }

            foreach (KeyValuePair<string, string> kvp in dicGrades)
            {
                var ele = doc.CreateElement("Grade");
                ele.SetAttribute("Type", kvp.Key);//Type属性
                //低温,舒适,炎热
                string[] gradeNames = kvp.Value.Split(',');
                for (int i = 1; i <= gradeNames.Length; i++)
                {
                    var childEle = doc.CreateElement("Grade" + i);
                    childEle.InnerText = gradeNames[i - 1];
                    ele.AppendChild(childEle);
                }
                root.AppendChild(ele);
            }
            doc.AppendChild(root);
            doc.Save(xmlPath);

        }

        /// <summary>
        /// 将报警配置信息写到txt文件中
        /// </summary>
        /// <param name="txtPath">文本文件路径</param>
        /// <param name="dicConditions">阈值条件集合</param>
        /// <param name="dicGrades">等级名称集合</param>
        public static void WriteAlarmSetsToTxt(string txtPath, Dictionary<string, string[]> dicConditions, Dictionary<string, string> dicGrades)
        {
            List<string> list = new List<string>();
            list.Add("数据预警阈值设置");
            foreach (string key in dicConditions.Keys)
            {
                list.Add(key);
                string[] contents = dicConditions[key];
                list.Add(contents[0]);
                list.Add(contents[1]);
            }
            list.Add("等级名称设置");
            foreach (string key in dicGrades.Keys)
            {
                list.Add(key);
                string[] grades = dicGrades[key].Split(',');
                list.Add($"第一级：{grades[0]}");
                list.Add($"第二级：{grades[1]}");
                list.Add($"第三级：{grades[2]}");
            }
            TextHelper.WriteMsgList(list, txtPath, false);
        }

        /// <summary>
        ///  将报警配置信息写到json文件中
        /// </summary>
        /// <param name="jsonPath"></param>
        /// <param name=""></param>
        /// <param name="dicConditions"></param>
        /// <param name="dicGrades"></param>
        public static void WriteAlarmSetsToJson(string jsonPath, Dictionary<string, string[]> dicConditions, Dictionary<string, string> dicGrades)
        {
            AlarmSetInfo alarmSet = ConvertToAlarmSet(dicConditions, dicGrades);
            //序列化成json字符串
            string json = JsonConvert.SerializeObject(alarmSet);
            //写入文件
            TextHelper.WriteMsg(json, jsonPath, false);
        }

    }
}
