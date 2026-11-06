using System;
using System.Data;
using System.Data.SQLite;
using Helper;

namespace IEMAWC.DAL
{
    public class ReportDAL
    {
        public int GetTotalCount(bool isAlarmReport, string reportType, string queryDate)
        {
            string tableName = isAlarmReport ? "AlarmLogInfos" : "DataInfos"; // 【已修改】
            string timeColumn = isAlarmReport ? "AlarmTime" : "CollectionTime";

            string timeCondition = GetTimeCondition(timeColumn, reportType, queryDate);
            string sql = $"SELECT COUNT(1) FROM {tableName} WHERE 1=1 {timeCondition}";

            object result = SQLiteHelper.ExecuteScalar(sql);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        public DataTable GetPageData(bool isAlarmReport, string reportType, string queryDate, int pageIndex, int pageSize)
        {
            int offset = (pageIndex - 1) * pageSize;
            string sql = "";

            if (isAlarmReport)
            {
                string timeCondition = GetTimeCondition("AlarmTime", reportType, queryDate);
                sql = $@"
                    SELECT 
                        LogId AS '记录编号',
                        CASE InfoType WHEN 0 THEN '温度' WHEN 1 THEN '湿度' WHEN 2 THEN '亮度' ELSE '未知' END AS '报警类型',
                        AlarmTime AS '报警时间',
                        CASE AlarmState WHEN '1' THEN '高值异常' WHEN '0' THEN '低值异常' WHEN '2' THEN '预警' WHEN '3' THEN '取消异常' ELSE '未知' END AS '报警状态',
                        AlarmValue AS '报警值',
                        AlarmNote AS '报警描述'
                    FROM AlarmLogInfos 
                    WHERE 1=1 {timeCondition}
                    ORDER BY AlarmTime DESC LIMIT {pageSize} OFFSET {offset}"; // 【已修改】
            }
            else
            {
                string timeCondition = GetTimeCondition("CollectionTime", reportType, queryDate);
                sql = $@"
                    SELECT 
                        Id AS '记录编号',
                        CollectionTime AS '采集时间',
                        Temperature AS '温度(℃)',
                        Humidity AS '湿度(%)',
                        Brightness AS '亮度(lux)'
                    FROM DataInfos 
                    WHERE 1=1 {timeCondition}
                    ORDER BY CollectionTime DESC LIMIT {pageSize} OFFSET {offset}"; // 【已修改】
            }

            return SQLiteHelper.GetDataTable(sql);
        }

        //public ReportStatistics GetStatistics(bool isAlarmReport, string reportType, string queryDate)
        //{
        //    ReportStatistics stat = new ReportStatistics();
        //    string sql = "";

        //    if (isAlarmReport)
        //    {
        //        string timeCondition = GetTimeCondition("AlarmTime", reportType, queryDate);
        //        sql = $@"
        //            SELECT 
        //                COUNT(1) AS TotalCount,
        //                SUM(CASE WHEN AlarmState = '1' THEN 1 ELSE 0 END) AS HighCount,
        //                SUM(CASE WHEN AlarmState = '0' THEN 1 ELSE 0 END) AS LowCount,
        //                SUM(CASE WHEN AlarmState = '3' THEN 1 ELSE 0 END) AS CancelCount
        //            FROM AlarmLogInfos WHERE 1=1 {timeCondition}"; // 【已修改】

        //        DataTable dt = SQLiteHelper.GetDataTable(sql);
        //        if (dt.Rows.Count > 0)
        //        {
        //            DataRow row = dt.Rows[0];
        //            stat.TotalCount = row["TotalCount"] != DBNull.Value ? Convert.ToInt32(row["TotalCount"]) : 0;
        //            stat.HighCount = row["HighCount"] != DBNull.Value ? Convert.ToInt32(row["HighCount"]) : 0;
        //            stat.LowCount = row["LowCount"] != DBNull.Value ? Convert.ToInt32(row["LowCount"]) : 0;
        //            stat.CancelCount = row["CancelCount"] != DBNull.Value ? Convert.ToInt32(row["CancelCount"]) : 0;
        //        }
        //    }
        //    else
        //    {
        //        string timeCondition = GetTimeCondition("CollectionTime", reportType, queryDate);
        //        sql = $"SELECT COUNT(1) AS TotalCount FROM DataInfos WHERE 1=1 {timeCondition}"; // 【已修改】

        //        object result = SQLiteHelper.ExecuteScalar(sql);
        //        stat.TotalCount = result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
        //    }

        //    return stat;
        //}

        private string GetTimeCondition(string timeColumn, string reportType, string queryDate)
        {
            if (reportType == "日报表")
                return $" AND {timeColumn} LIKE '{queryDate}%'";
            if (reportType == "周报表")
                return $" AND strftime('%Y-%W', {timeColumn}) = strftime('%Y-%W', '{queryDate}')";
            if (reportType == "月报表")
                return $" AND strftime('%Y-%m', {timeColumn}) = strftime('%Y-%m', '{queryDate}')";
            return "";
        }
    }
}