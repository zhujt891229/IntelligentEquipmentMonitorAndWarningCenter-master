using Helper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.DAL.Base
{
    public class SQLiteQueryHelper
    {
        public static bool ExistByWhere(string tableName, string strWhere, params SQLiteParameter[] paras)
        {
            string sql = $"select count(1) from {tableName} where {strWhere}";
            object oCount = SQLiteHelper.ExecuteScalar(sql, paras);
            if (oCount != null && oCount.ToString() != "")
                return Convert.ToInt32(oCount) > 0;
            return false;
        }
    }
}
