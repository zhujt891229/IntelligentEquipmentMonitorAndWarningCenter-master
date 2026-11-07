using SqlSugar;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.DAL.Helper
{
    public class SQLHelper
    {
        private SQLHelper() { }
        //懒汉式单例模式
        private static SqlSugarClient? _instance;
        private static readonly object _lock = new object();
        
        // 获取 SqlSugarClient 实例
        public static SqlSugarClient Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SqlSugarClient(new ConnectionConfig()
                            {
                                DbType = GetCurrentDbType(),
                                //ConnectionString = "Data Source=WIN-M1LAMQN78SB;Initial Catalog=HX_XIANSAO;Persist Security Info=True;User ID=zhu;Password=123456",
                                //ConnectionString = "Server=localhost;Database=HX_XIANSAO;User Id=sa;Password=123456;TrustServerCertificate=True;",
                                //ConnectionString = ConfigurationManager.AppSettings["SQLServerConn"],
                                //ConnectionString = ConfigurationManager.ConnectionStrings["SQLServerConn"]?.ConnectionString
                                //    ?? "Server=.;Database=IEMAWC;Trusted_Connection=True;TrustServerCertificate=True;",
                                ConnectionString = GetConnectionString(GetCurrentDbType()),
                                IsAutoCloseConnection = true
                            }, db =>
                            {
                                db.Aop.OnLogExecuting = (sql, pars) =>
                                {
                                    //Console.WriteLine(sql + "\r\n" +
                                    //db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                                    Console.WriteLine(UtilMethods.GetNativeSql(sql, pars));
                                };
                            });
                        }
                    }
                }
                return _instance;
            }
        }
        
        //根据配置文件获取当前数据库类型
        private static DbType GetCurrentDbType()
        {
            var value = ConfigurationManager.AppSettings["DbProvider"];
            if (string.IsNullOrWhiteSpace(value))
            {
                return DbType.Sqlite; // 默认保留原有 SQLite
            }

            if (Enum.TryParse(value, true, out DbType dbType))
            {
                return dbType;
            }

            return DbType.Sqlite;
        }
        //根据数据库类型获取对应的连接字符串
        public static string GetConnectionString(DbType dbType)
        {
            switch (dbType)
            {
                case DbType.SqlServer:
                    return ConfigurationManager.ConnectionStrings["SqlServerConn"]?.ConnectionString
                           ?? "Server=.;Database=IEMAWC;User Id=zhu;Password=123456;Trusted_Connection=True;TrustServerCertificate=True;";
                case DbType.Sqlite:
                    return ConfigurationManager.ConnectionStrings["SqliteConn"]?.ConnectionString
                           ?? "Data Source=IEMAWC.db;Version=3;";
                default:
                    throw new NotSupportedException($"Unsupported DbType: {dbType}");
            }
        }
        
    }
}
