using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligentEquipmentMonitorAndWarningCenter.Models;
using IntelligentEquipmentMonitorAndWarningCenter.SysConfigs;
using Zhaoxi.IntelligentDeviceMonitorAndWarningCenter.Models;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class CommonHelper
    {
        //存储目录路径
        public static string storePath = "";
        //存储路径文本文件路径
        public static string storePathFile = "";

        //通信配置信息对象
        public static CommunicateSet communicateSet = null;

        //数据库文件路径
        public static string dbFile = "";
        //通信配置文件路径
        public static string communicationFile = "";
        //预警配置文件路径
        public static string alarmSetsFile = "";
        //预警配置信息对象
        public static AlarmSetInfo alarmsets = null;

        //定义通信状态的布尔值
        public static bool communicationState = false;
        //定义一个委托，用来刷新设备连接信息
        public static Action reloadCommunicationState = null;
        public static void NotifyCommunicationStateChanged()
        {
            reloadCommunicationState?.Invoke();
        }


        //是否启用配置的状态
        public static bool isEnableSetting = false;

        // 刷新配置页面的设置状态 的委托
        public static Action reloadSettingState = null;
        //原来数据库文件的路径 --临时
        public static string oldDbFilePath = "";


        public static event Action AlarmSetsUpdated;
        public static void UpdateAlarmSets(AlarmSetInfo newSet)
        {
            alarmsets = newSet;
            AlarmSetsUpdated?.Invoke(); // 触发事件
        }
    }
}
