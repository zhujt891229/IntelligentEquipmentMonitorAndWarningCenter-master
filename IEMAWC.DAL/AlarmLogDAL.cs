using Helper;
using IEMAWC.DAL.Helper;
using NPOI.SS.Formula.Functions;
using SqlSugar;
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
            /*
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
            */
            return SQLHelper.Instance.Insertable<AlarmLog>(alarm).ExecuteCommand();
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
            
            // 1. 初始化查询
            var query = SQLHelper.Instance.Queryable<AlarmLog>()
                .Where(it => it.AlarmType == alarmType); // 基础条件：AlarmType

            // 2. 动态条件：报警状态 (多选 IN)
            // WhereIF: 只有当 states 不为空且包含元素时才添加条件
            // In: SqlSugar 会自动将其转换为参数化查询 (@p0, @p1...)，防止注入
            if (states != null && states.Any())
            {
                query = query.Where(it => states.Contains(it.AlarmState));
            }

            // 3. 动态条件：报警来源 (InfoType)
            // 假设 -1 代表“全部”，其他值代表特定类型
            if (infoType != -1)
            {
                query = query.Where(it => it.InfoType == infoType);
            }

            // 4. 动态条件：时间范围
            // 建议将字符串转换为 DateTime 进行比较，确保类型安全
            if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr))
            {
                if (DateTime.TryParse(startStr, out DateTime startTime) &&
                    DateTime.TryParse(endStr, out DateTime endTime))
                {
                    query = query.Where(it => DateTime.Parse(it.AlarmTime) >= startTime && DateTime.Parse(it.AlarmTime) <= endTime);
                }
            }
            // 5. 执行计数
            return query.Count();
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
            // 1. 白名单校验表名
            string tableName = "AlarmLog";

            // 2. 构建动态条件列表
            var conditions = new List<IConditionalModel>();

            // 基础条件
            conditions.Add(new ConditionalModel
            {
                FieldName = "AlarmType",
                ConditionalType = ConditionalType.Equal,
                FieldValue = alarmType.ToString()
            });

            // 动态 IN 条件
            if (states != null && states.Any())
            {
                // 注意：In 条件需要特殊处理，这里使用 Where 字符串拼接更安全
                // 或者使用 query.In("AlarmState", states.ToArray())
            }

            // 3. 构建查询对象
            var query = SQLHelper.Instance.Queryable<dynamic>()
                .AS(tableName)
                .Where(conditions);

            // 4. 处理动态 IN 条件 (使用 In 扩展方法，自动参数化)
            if (states != null && states.Any())
            {
                query = query.In("AlarmState", states.ToArray());
            }

            // 5. 处理其他动态条件
            if (infoType != -1)
            {
                query = query.Where("InfoType = @InfoType", new { InfoType = infoType });
            }

            if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr))
            {
                query = query.Where("AlarmTime >= @StartTime AND AlarmTime <= @EndTime", new
                {
                    StartTime = startStr,
                    EndTime = endStr
                });
            }

            // 6. 定义 Select 字段 (保留原 SQL 中的 CASE WHEN 逻辑)
            string selectSql = @"
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
        END AS AlarmTypeName";

            // 7. 执行分页查询
            var list = query
                .OrderBy("AlarmTime DESC")
                .Select(selectSql)
                .ToPageList(pageIndex, pageSize);

            // 8. 转换为 DataTable
            return SQLHelper.Instance.Utilities.ListToDataTable(list);
        }

        /// <summary>
        /// 批量删除报警记录
        /// </summary>
        public int DeleteByIds(List<long> ids)
        {
            /*
            if (ids == null || ids.Count == 0) return 0;

            // 将 List 转换成 SQL 的 IN 格式，例如: "1,2,3"
            string inClause = string.Join(",", ids);

            // 修改点：把 Id 改成 LogId
            string sql = $"DELETE FROM AlarmLogInfos WHERE LogId IN ({inClause})";

            // 注意：如果你的 SQLiteHelper.ExecuteNonQuery 需要传空参数数组，请写成：
            return SQLiteHelper.ExecuteNonQuery(sql, new SQLiteParameter[] { });
            // 或者如果你之前的方法有重载，直接像你截图里那样传即可
            */
            return SQLHelper.Instance.Deleteable<AlarmLog>().Where(it => ids.Contains(it.LogId)).ExecuteCommand();
        }
    }
}