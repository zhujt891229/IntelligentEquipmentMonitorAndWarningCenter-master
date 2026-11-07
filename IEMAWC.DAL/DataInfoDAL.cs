using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;
using Helper;
using IEMAWC.DAL.Helper;
using NPOI.SS.Formula.Functions;
using SqlSugar;

namespace IEMAWC.DAL
{
    public class DataInfoDAL
    {
       
        /// 插入一条数据到 DataInfos 表，并返回自增主键 Id。
        /// </summary>
        /// <param name="info">要插入的数据实体。</param>
        /// <returns>新插入记录的自增 Id；失败返回 -1。</returns>
        public int InsertDataToDataInfos(DataInfo info) {
            string sql = @"INSERT INTO DataInfos 
                           (CollectionTime, Temperature, Humidity, Brightness) 
                           VALUES 
                           (@CollectionTime, @Temperature, @Humidity, @Brightness);
                           SELECT last_insert_rowid();";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@CollectionTime", info.CollectionTime),
                new SQLiteParameter("@Temperature",    info.Temperature),
                new SQLiteParameter("@Humidity",       info.Humidity),
                new SQLiteParameter("@Brightness",     info.Brightness)
            };
            object result = SQLiteHelper.ExecuteScalar(sql, paras);
            if (result == null || result == DBNull.Value)
                return -1;

            return Convert.ToInt32(result);
        }

        //获得最新日期的前十条数据
        /// <summary>
        /// 获取按采集时间倒序排列的前 10 条数据。
        /// </summary>
        public BindingList<DataInfo> GetTenNewDataFromDataInfos()
        {
            string sql = @"SELECT Id, CollectionTime, Temperature, Humidity, Brightness 
                           FROM DataInfos 
                           ORDER BY CollectionTime DESC, Id DESC 
                           LIMIT 10";

            DataTable dt = SQLiteHelper.GetDataTable(sql);
            return ConvertToDataInfoList(dt);
        }

        /// <summary>
        /// DataTable -> List&lt;DataInfo&gt;
        /// </summary>
        private BindingList<DataInfo> ConvertToDataInfoList(DataTable dt)
        {
            BindingList<DataInfo> list = new BindingList<DataInfo>();

            if (dt == null || dt.Rows.Count == 0)
                return list;

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DataInfo
                {
                    Id = Convert.ToInt32(row["Id"]),
                    CollectionTime = row["CollectionTime"].ToString(),
                    Temperature = Convert.ToDouble(row["Temperature"]),
                    Humidity = Convert.ToDouble(row["Humidity"]),
                    Brightness = Convert.ToDouble(row["Brightness"])
                });
            }
            return list;
        }


        private const string Cols = "Id,CollectionTime,Temperature,Humidity,Brightness";
        public List<DataInfo> GetDataInfos(DateTime start, DateTime end)
        {
            /*
            string sql = $"select {Cols} from DataInfos where CollectionTime>=@start and CollectionTime<=@end order by Id";
            SQLiteDataReader dr = SQLiteHelper.ExecuteReader(sql, BuildTimeParas(start, end));
            return DbConvert.DataReaderToList<DataInfo>(dr, Cols);
            */
            return SQLHelper.Instance.Queryable<DataInfo>().Where(it => DateTime.Parse(it.CollectionTime) >= start && DateTime.Parse(it.CollectionTime) <= end).OrderBy(it => it.Id).ToList();
        }

        public List<DataInfo> GetLatestDataInfos(int count)
        {
            /*
            string sql = $"select {Cols} from DataInfos order by Id desc limit {count}";
            SQLiteDataReader dr = SQLiteHelper.ExecuteReader(sql);
            List<DataInfo> list = DbConvert.DataReaderToList<DataInfo>(dr, Cols);
            list.Reverse();//倒序取出后再反转，最终按时间升序排列，便于绘制曲线
            return list;
            */
            return SQLHelper.Instance.Queryable<DataInfo>().OrderBy(it => it.Id, SqlSugar.OrderByType.Desc).Take(count).ToList().Reverse<DataInfo>().ToList();
        }

        public List<DataInfo> GetDataInfosByPage(DateTime start, DateTime end, int pageIndex, int pageSize)
        {
            /*
            int offset = (pageIndex - 1) * pageSize;
            string sql = $"select {Cols} from DataInfos where CollectionTime>=@start and CollectionTime<=@end " +
                         $"order by Id desc limit {pageSize} offset {offset}";
            SQLiteDataReader dr = SQLiteHelper.ExecuteReader(sql, BuildTimeParas(start, end));
            return DbConvert.DataReaderToList<DataInfo>(dr, Cols);
            */
            return SQLHelper.Instance.Queryable<DataInfo>().Where(it => DateTime.Parse(it.CollectionTime) >= start && DateTime.Parse(it.CollectionTime) <= end).OrderBy(it => it.Id, SqlSugar.OrderByType.Desc).ToPageList(pageIndex, pageSize);
        }

        public int GetDataCount(DateTime start, DateTime end)
        {
            /*
            string sql = "select count(1) from DataInfos where CollectionTime>=@start and CollectionTime<=@end";
            object oCount = SQLiteHelper.ExecuteScalar(sql, BuildTimeParas(start, end));
            if (oCount != null && oCount != DBNull.Value)
            {
                return Convert.ToInt32(oCount);
            }
            return 0;
            */
            return SQLHelper.Instance.Queryable<DataInfo>().Where(it => DateTime.Parse(it.CollectionTime) >= start && DateTime.Parse(it.CollectionTime) <= end).Count();
        }

        public (double avgT, double avgH, double avgB) GetDataAverage(DateTime start, DateTime end)
        {
            /*
            string sql = "select ifnull(avg(Temperature),0) as avgT,ifnull(avg(Humidity),0) as avgH," +
                         "ifnull(avg(Brightness),0) as avgB from DataInfos " +
                         "where CollectionTime>=@start and CollectionTime<=@end";
            DataTable dt = SQLiteHelper.GetDataTable(sql, BuildTimeParas(start, end));
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return (Convert.ToDouble(row["avgT"]), Convert.ToDouble(row["avgH"]), Convert.ToDouble(row["avgB"]));
            }
            return (0, 0, 0);
            */
            var value = SQLHelper.Instance.Queryable<DataInfo>().Where(it => DateTime.Parse(it.CollectionTime) >= start && DateTime.Parse(it.CollectionTime) <= end).Select(it => new {AvgT=SqlFunc.AggregateAvg(it.Temperature), AvgH = SqlFunc.AggregateAvg(it.Humidity), AvgB = SqlFunc.AggregateAvg(it.Brightness) }).First();
            return (value.AvgT, value.AvgH, value.AvgB);
        }

        private static SQLiteParameter[] BuildTimeParas(DateTime start, DateTime end)
        {
            return new SQLiteParameter[]
            {
                new SQLiteParameter("@start",start.ToString("yyyy-MM-dd HH:mm:ss")),
                new SQLiteParameter("@end",end.ToString("yyyy-MM-dd HH:mm:ss"))
            };
        }
    }
}
