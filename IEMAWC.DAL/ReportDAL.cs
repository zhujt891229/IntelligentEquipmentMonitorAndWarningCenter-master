using Dm.util;
using Helper;
using IEMAWC.DAL.Helper;
using SqlSugar;
using System;
using System.Data;
using System.Data.SQLite;

namespace IEMAWC.DAL
{
    public class ReportDAL
    {
        public int GetTotalCount(bool isAlarmReport, string reportType, string queryDate)
        {
            /*
            string tableName = isAlarmReport ? "AlarmLogInfos" : "DataInfos"; 
            string timeColumn = isAlarmReport ? "AlarmTime" : "CollectionTime";

            string timeCondition = GetTimeCondition(timeColumn, reportType, queryDate);
            string sql = $"SELECT COUNT(1) FROM {tableName} WHERE 1=1 {timeCondition}";
            
            object result = SQLiteHelper.ExecuteScalar(sql);
            return result != null && result != DBNull.Value ? Convert.ToInt32(result) : 0;
            */
            // 1. 白名单校验表名和字段名 (至关重要，防止注入)
            string tableName = isAlarmReport ? "AlarmLog" : "DataInfo";
            string timeColumn = isAlarmReport ? "AlarmTime" : "CollectionTime";

            // 简单的白名单检查
            var allowedTables = new[] { "AlarmLog", "DataInfo" };
            if (!allowedTables.Contains(tableName)) throw new Exception("非法表名");

            // 2. 计算时间范围 (替代原有的字符串拼接逻辑)
            DateTime startTime, endTime;

            if (reportType == "日报表")
            {
                startTime = DateTime.Parse(queryDate).Date;
                endTime = DateTime.Parse(queryDate).Date.AddDays(1);
            }
            else if (reportType == "月报表")
            {
                startTime = new DateTime(DateTime.Parse(queryDate).Year, DateTime.Parse(queryDate).Month, 1);
                endTime = startTime.AddMonths(1);
            }
            else if (reportType == "周报表")
            {
                // 计算本周起始时间 (假设周一为起点)
                int diff = (7 + (DateTime.Parse(queryDate).DayOfWeek - DayOfWeek.Monday)) % 7;
                startTime = DateTime.Parse(queryDate).Date.AddDays(-diff);
                endTime = startTime.AddDays(7);
            }
            else
            {
                throw new ArgumentException("无效的报表类型");
            }

            // 3. 构建动态条件列表
            var conditions = new List<IConditionalModel>();

            // 添加 >= 开始时间
            conditions.Add(new ConditionalModel()
            {
                FieldName = timeColumn,
                ConditionalType = ConditionalType.GreaterThanOrEqual,
                FieldValue = startTime.ToString("yyyy-MM-dd HH:mm:ss.fff"), // SQLite 兼容格式
                CSharpTypeName = "DateTime" // 提示 SqlSugar 进行类型转换
            });

            // 添加 < 结束时间
            conditions.Add(new ConditionalModel()
            {
                FieldName = timeColumn,
                ConditionalType = ConditionalType.LessThan,
                FieldValue = endTime.ToString("yyyy-MM-dd HH:mm:ss.fff"),
                CSharpTypeName = "DateTime"
            });

            // 4. 执行查询
            // .AS(tableName) 动态指定表名
            // .Where(conditions) 自动参数化，生成 WHERE [AlarmTime] >= @p0 AND [AlarmTime] < @p1
            return SQLHelper.Instance.Queryable<dynamic>()
                     .AS(tableName)
                     .Where(conditions)
                     .Count();
        }
        // 辅助方法：计算时间范围，保持逻辑清晰


        public DataTable GetPageData(bool isAlarmReport, string reportType, string queryDate, int pageIndex, int pageSize)
        {
            /*
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
            */

            // 1. 计算分页参数
            int offset = (pageIndex - 1) * pageSize;

            if (isAlarmReport)
            {
                // --- 报警日志查询 ---
                var query = SQLHelper.Instance.Queryable<AlarmLog>()
                    .AS("AlarmLog") // 确保表名正确
                    .OrderBy(it => it.AlarmTime, OrderByType.Desc);

                // 2. 动态时间条件 (使用 WhereIF 或 IConditionalModel)
                ApplyTimeFilter(query, "AlarmTime", reportType, DateTime.Parse(queryDate));

                // 3. 执行查询并映射结果
                // ToPageList 返回 List<T>，我们需要将其转换为 DataTable 以匹配原接口返回类型
                var list = query.ToPageList(pageIndex, pageSize);

                // 4. 内存中处理 CASE WHEN 逻辑 (或者在 Select 中处理，见下方注释)
                var resultTable = ConvertAlarmListToDataTable(list);
                return resultTable;
            }
            else
            {
                // --- 数据采集查询 ---
                var query = SQLHelper.Instance.Queryable<DataInfo>()
                    .AS("DataInfo")
                    .OrderBy(it => it.CollectionTime, OrderByType.Desc);

                ApplyTimeFilter(query, "CollectionTime", reportType, DateTime.Parse(queryDate));

                var list = query.ToPageList(pageIndex, pageSize);

                // 直接映射为 DataTable，字段名自动对应
                return SQLHelper.Instance.Utilities.ListToDataTable(list);
            }

        }
        private void ApplyTimeFilter<T>(ISugarQueryable<T> query, string columnName, string reportType, DateTime queryDate) where T : class
        {
            // 注意：由于泛型限制，这里推荐使用 IConditionalModel 方式，或者针对具体实体写重载
            // 为了演示简洁，这里展示如何使用 IConditionalModel 附加到 query
            // 实际项目中建议分别为 AlarmLogInfo 和 DataInfo 写具体的 Lambda 表达式

            DateTime startTime, endTime;
            GetTimeRange(reportType, queryDate, out startTime, out endTime);

            // 使用 IConditionalModel 动态添加条件
            var conditions = new List<IConditionalModel>
            {
                new ConditionalModel { FieldName = columnName, ConditionalType = ConditionalType.GreaterThanOrEqual, FieldValue = startTime.toString() },
                new ConditionalModel { FieldName = columnName, ConditionalType = ConditionalType.LessThan, FieldValue = endTime.toString() }
            };

            // 注意：ISugarQueryable 没有直接的 Where(List) 扩展，通常需要在构建 query 时链式调用
            // 更优雅的方式是使用 WhereIF (如果是强类型 Lambda)
        }
        private void GetTimeRange(string reportType, DateTime queryDate, out DateTime startTime, out DateTime endTime)
        {
            if (reportType == "日报表")
            {
                startTime = queryDate.Date;
                endTime = queryDate.Date.AddDays(1);
            }
            else if (reportType == "月报表")
            {
                startTime = new DateTime(queryDate.Year, queryDate.Month, 1);
                endTime = startTime.AddMonths(1);
            }
            else if (reportType == "周报表")
            {
                // 简单计算本周周一到下周周一
                int diff = (7 + (queryDate.DayOfWeek - DayOfWeek.Monday)) % 7;
                startTime = queryDate.Date.AddDays(-diff);
                endTime = startTime.AddDays(7);
            }
            else
            {
                startTime = queryDate.Date;
                endTime = queryDate.Date.AddDays(1);
            }
        }
        private DataTable ConvertAlarmListToDataTable(List<AlarmLog> list)
        {
            var dt = new DataTable();
            dt.Columns.Add("记录编号", typeof(int));
            dt.Columns.Add("报警类型", typeof(string));
            dt.Columns.Add("报警时间", typeof(DateTime));
            dt.Columns.Add("报警状态", typeof(string));
            dt.Columns.Add("报警值", typeof(decimal)); // 假设类型
            dt.Columns.Add("报警描述", typeof(string));

            foreach (var item in list)
            {
                var row = dt.NewRow();
                row["记录编号"] = item.LogId;

                // CASE InfoType WHEN ...
                row["报警类型"] = item.InfoType switch
                {
                    0 => "温度",
                    1 => "湿度",
                    2 => "亮度",
                    _ => "未知"
                };

                row["报警时间"] = item.AlarmTime;

                // CASE AlarmState WHEN ...
                row["报警状态"] = item.AlarmState switch
                {
                    "1" => "高值异常",
                    "0" => "低值异常",
                    "2" => "预警",
                    "3" => "取消异常",
                    _ => "未知"
                };

                row["报警值"] = item.AlarmValue;
                row["报警描述"] = item.AlarmNote;
                dt.Rows.Add(row);
            }
            return dt;
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