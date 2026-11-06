using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class AlarmStatisticsData
    {
        public int TotalCount { get; set; }        // 异常记录总数
        public int HighAlarmCount { get; set; }    // 高值异常
        public int LowAlarmCount { get; set; }     // 低值异常
        public int CancelAlarmCount { get; set; }  // 取消异常 (根据你的截图补充)

        public int DeviceWarningTotal { get; set; }// 设备预警总数
        public int TempWarningCount { get; set; }  // 温度预警
        public int HumWarningCount { get; set; }   // 湿度预警
        public int LightWarningCount { get; set; } // 亮度预警
    }

    /// <summary>
    /// 报警数据管理器（负责查询数据和触发刷新事件）
    /// </summary>
    public class AlarmDataManager
    {
        // 定义委托：用于通知UI数据已更新
        public delegate void DataUpdatedHandler(AlarmStatisticsData data);

        // 定义事件：当数据发生变化时触发
        public event DataUpdatedHandler OnDataUpdated;

        /// <summary>
        /// 从数据库拉取最新统计数据
        /// </summary>
        public void RefreshData()
        {
            try
            {
                AlarmStatisticsData stats = new AlarmStatisticsData();

                // 1. 基础异常统计 (根据 AlarmType 和 AlarmState 统计)
                // 假设所有记录都在 AlarmLogInfos 表
                string sqlBase = @"
                    SELECT 
                        COUNT(*) as TotalCount,
                        SUM(CASE WHEN AlarmState = '1' THEN 1 ELSE 0 END) as HighCount,
                        SUM(CASE WHEN AlarmState = '0' THEN 1 ELSE 0 END) as LowCount,
                        SUM(CASE WHEN AlarmNote LIKE '%取消%' THEN 1 ELSE 0 END) as CancelCount
                    FROM AlarmLogInfos"; // 如果你的表名不同，请修改这里

                DataTable dtBase = SQLiteHelper.GetDataTable(sqlBase);
                if (dtBase.Rows.Count > 0)
                {
                    DataRow row = dtBase.Rows[0];
                    stats.TotalCount = row["TotalCount"] != DBNull.Value ? Convert.ToInt32(row["TotalCount"]) : 0;
                    stats.HighAlarmCount = row["HighCount"] != DBNull.Value ? Convert.ToInt32(row["HighCount"]) : 0;
                    stats.LowAlarmCount = row["LowCount"] != DBNull.Value ? Convert.ToInt32(row["LowCount"]) : 0;
                    stats.CancelAlarmCount = row["CancelCount"] != DBNull.Value ? Convert.ToInt32(row["CancelCount"]) : 0;
                }

                // 2. 设备预警统计 (根据 InfoType 统计)
                // InfoType: 0 温度，1 湿度，2 亮度
                string sqlWarning = @"
                    SELECT 
                        COUNT(*) as WarningTotal,
                        SUM(CASE WHEN InfoType = 0 THEN 1 ELSE 0 END) as TempCount,
                        SUM(CASE WHEN InfoType = 1 THEN 1 ELSE 0 END) as HumCount,
                        SUM(CASE WHEN InfoType = 2 THEN 1 ELSE 0 END) as LightCount
                    FROM AlarmLogInfos";

                DataTable dtWarning = SQLiteHelper.GetDataTable(sqlWarning);
                if (dtWarning.Rows.Count > 0)
                {
                    DataRow row = dtWarning.Rows[0];
                    stats.DeviceWarningTotal = row["WarningTotal"] != DBNull.Value ? Convert.ToInt32(row["WarningTotal"]) : 0;
                    stats.TempWarningCount = row["TempCount"] != DBNull.Value ? Convert.ToInt32(row["TempCount"]) : 0;
                    stats.HumWarningCount = row["HumCount"] != DBNull.Value ? Convert.ToInt32(row["HumCount"]) : 0;
                    stats.LightWarningCount = row["LightCount"] != DBNull.Value ? Convert.ToInt32(row["LightCount"]) : 0;
                }

                // 数据查询完毕，触发事件通知订阅者（UI窗体）
                OnDataUpdated?.Invoke(stats);
            }
            catch (Exception ex)
            {
                // 这里可以加上日志记录逻辑
                Console.WriteLine("刷新统计数据失败：" + ex.Message);
            }
        }
    }

}
