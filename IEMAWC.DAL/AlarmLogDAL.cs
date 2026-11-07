using Helper;
using IEMAWC.DAL.Helper;
using System;
using System.Data;
using System.Data.SQLite;

namespace IEMAWC.DAL
{
    // 报警信息实体类，对应数据库表
    public class AlarmLogDAL
    {
        public int InsertAlarmToDatabase(AlarmLog alarm)
        {

            string sql = @"INSERT INTO AlarmLogInfos 
                       (InfoType, AlarmTime, AlarmType, AlarmState, AlarmValue, AlarmNote)
                       VALUES 
                       (@InfoType, @AlarmTime, @AlarmType, @AlarmState, @AlarmValue, @AlarmNote)";
            //构建参数数组
            SQLiteParameter[] paras = new SQLiteParameter[]
            {
                new SQLiteParameter("@InfoType",   alarm.InfoType),
                new SQLiteParameter("@AlarmTime",  alarm.AlarmTime),
                new SQLiteParameter("@AlarmType",  alarm.AlarmType),
                new SQLiteParameter("@AlarmState", alarm.AlarmState),
                new SQLiteParameter("@AlarmValue", alarm.AlarmValue),
                new SQLiteParameter("@AlarmNote",  alarm.AlarmNote)
            };

            return SQLiteHelper.ExecuteNonQuery(sql, paras);
        }

        //根据条件查询合法的数据
        //public DataTable QueryLegalData(int alarmType, List<string> states,
        //                            int infoType, DateTime startTime, DateTime endTime)
        //{
        //    // 拼 SQL（和你原来一样）
        //    var whereList = new List<string>();
        //    var paras = new List<SQLiteParameter>();

        //    whereList.Add("AlarmType = @alarmType");
        //    paras.Add(new SQLiteParameter("@alarmType", alarmType));

        //    if (states != null && states.Count > 0)
        //    {
        //        var names = new List<string>();
        //        for (int i = 0; i < states.Count; i++)
        //        {
        //            string p = "@s" + i;
        //            names.Add(p);
        //            paras.Add(new SQLiteParameter(p, states[i]));
        //        }
        //        whereList.Add($"AlarmState IN ({string.Join(", ", names)})");
        //    }

        //    if (infoType != -1)
        //    {
        //        whereList.Add("InfoType = @infoType");
        //        paras.Add(new SQLiteParameter("@infoType", infoType));
        //    }

        //    whereList.Add("AlarmTime >= @startTime AND AlarmTime < @endTime");
        //    paras.Add(new SQLiteParameter("@startTime", startTime.ToString("yyyy-MM-dd HH:mm:ss")));
        //    paras.Add(new SQLiteParameter("@endTime", endTime.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss")));

        //    string sql = "SELECT * FROM AlarmLog WHERE " + string.Join(" AND ", whereList)
        //               + " ORDER BY AlarmTime DESC";

        //    return SQLiteHelper.GetDataTable(sql, paras.ToArray());
        //}

        // 数据库连接字符串（请替换为你实际的路径）

        // 查询总的报警数量
        public int GetTotalCount(int alarmType, List<string> states, int infoType, string startStr, string endStr)
        {
            /*
            string sql = "SELECT COUNT(1) FROM AlarmLogInfos WHERE AlarmType = @AlarmType";
            List<SQLiteParameter> paras = new List<SQLiteParameter>
            {
                new SQLiteParameter("@AlarmType", alarmType)
            };

            // 报警状态 (多选)
            if (states != null && states.Count > 0)
            {
                string inClause = string.Join(",", states.ConvertAll(s => $"'{s}'"));
                sql += $" AND AlarmState IN ({inClause})";
            }

            // 报警来源 (InfoType)
            if (infoType != -1)
            {
                sql += " AND InfoType = @InfoType";
                paras.Add(new SQLiteParameter("@InfoType", infoType));
            }

            // 时间范围
            if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr))
            {
                sql += " AND AlarmTime >= @StartTime AND AlarmTime <= @EndTime";
                paras.Add(new SQLiteParameter("@StartTime", startStr));
                paras.Add(new SQLiteParameter("@EndTime", endStr));
            }

            object result = SQLiteHelper.ExecuteScalar(sql, paras.ToArray());
            return result != null ? Convert.ToInt32(result) : 0;
            */
            int count = SQLHelper.Instance.Queryable<AlarmLog>().Where(a => a.AlarmType == alarmType
                && (states == null || states.Count == 0 || states.Contains(a.AlarmState))
                && (infoType == -1 || a.InfoType == infoType)
                && (string.IsNullOrEmpty(startStr) || DateTime.Parse(a.AlarmTime) >= DateTime.Parse(startStr))
                && (string.IsNullOrEmpty(endStr) || DateTime.Parse(a.AlarmTime) <= DateTime.Parse(endStr)))
                .Count();
            return count;
        }

        /// <summary>
        /// 分页获取报警记录
        /// </summary>
        public DataTable GetList(int alarmType, List<string> states, int infoType, string startStr, string endStr, int pageIndex, int pageSize)
        {
            /*
            string sql = @"
            SELECT 
                LogId, 
                AlarmTime, 
                AlarmValue, 
                AlarmNote,
                CASE InfoType 
                    WHEN 0 THEN '温度'
                    WHEN 1 THEN '湿度'
                    WHEN 2 THEN '亮度'
                    ELSE '未知' 
                END AS InfoTypeName,
                CASE AlarmState 
                    WHEN '1' THEN '高值异常'
                    WHEN '0' THEN '低值异常'
                    WHEN '2' THEN '取消高值异常'
                    WHEN '3' THEN '取消低值异常'
                    ELSE '未知' 
                END AS AlarmStateName,
                CASE AlarmType
                    WHEN 0 THEN '实时报警'
                    WHEN 1 THEN '历史报警'
                    ELSE '未知'
                END AS AlarmTypeName
            FROM AlarmLogInfos 
            WHERE AlarmType = @AlarmType";
            List<SQLiteParameter> paras = new List<SQLiteParameter>
            {
                new SQLiteParameter("@AlarmType", alarmType)
            };

            if (states != null && states.Count > 0)
            {
                string inClause = string.Join(",", states.ConvertAll(s => $"'{s}'"));
                sql += $" AND AlarmState IN ({inClause})";
            }

            if (infoType != -1)
            {
                sql += " AND InfoType = @InfoType";
                paras.Add(new SQLiteParameter("@InfoType", infoType));
            }
                
            if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr))
            {
                sql += " AND AlarmTime >= @StartTime AND AlarmTime <= @EndTime";
                paras.Add(new SQLiteParameter("@StartTime", startStr));
                paras.Add(new SQLiteParameter("@EndTime", endStr));
            }

            // 排序并按页截取
            sql += " ORDER BY AlarmTime DESC LIMIT @PageSize OFFSET @Offset";
            paras.Add(new SQLiteParameter("@PageSize", pageSize));
            paras.Add(new SQLiteParameter("@Offset", (pageIndex - 1) * pageSize));

            return SQLiteHelper.GetDataTable(sql, paras.ToArray());
            */
            DataTable dataTable = SQLHelper.Instance.Queryable<AlarmLog>().Where(a => a.AlarmType == alarmType
                && (states == null || states.Count == 0 || states.Contains(a.AlarmState))
                && (infoType == -1 || a.InfoType == infoType)
                && (string.IsNullOrEmpty(startStr) || DateTime.Parse(a.AlarmTime) >= DateTime.Parse(startStr))
                && (string.IsNullOrEmpty(endStr) || DateTime.Parse(a.AlarmTime) <= DateTime.Parse(endStr)))
                .OrderByDescending(a => a.AlarmTime)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToDataTable();
            return dataTable;
        }

        /// <summary>
        /// 批量删除报警记录
        /// </summary>
        public int DeleteByIds(List<long> ids)
        {
            if (ids == null || ids.Count == 0) return 0;

            // 将 List 转换成 SQL 的 IN 格式，例如: "1,2,3"
            string inClause = string.Join(",", ids);

            // 修改点：把 Id 改成 LogId
            string sql = $"DELETE FROM AlarmLogInfos WHERE LogId IN ({inClause})";

            // 注意：如果你的 SQLiteHelper.ExecuteNonQuery 需要传空参数数组，请写成：
            return SQLiteHelper.ExecuteNonQuery(sql, new SQLiteParameter[] { });
            // 或者如果你之前的方法有重载，直接像你截图里那样传即可
        }
    }
}