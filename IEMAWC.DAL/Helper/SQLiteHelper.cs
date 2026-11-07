using NPOI.POIFS.Crypt;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using System.Configuration;

namespace Helper
{
    /// <summary>
    /// SQLite 数据库操作帮助类。
    /// 提供连接字符串读取、增删改查、事务处理等常用数据库操作方法。
    /// </summary>
    public class SQLiteHelper
    {
        /// <summary>
        /// 数据库连接字符串（只读，程序启动时从配置文件中读取一次）。
        /// </summary>
        public static readonly string connString = ConnString;

        /// <summary>
        /// 从程序集对应的配置文件中读取名为 "connString" 的数据库连接字符串。
        /// 配置文件路径为：{入口程序集名称}.dll.config。
        /// </summary>
        public static string ConnString
        {
            get
            {
                /*
                string connStr = "";
                XmlDocument cfgDoc = new XmlDocument();

                // 获取入口程序集名称，并拼接为 .dll.config 配置文件路径
                string path = ((Assembly.GetEntryAssembly()).GetName()).Name + ".dll.config";
                cfgDoc.Load(path);

                XmlElement root = cfgDoc.DocumentElement;
                XmlNode node = cfgDoc.SelectSingleNode("//connectionStrings");

                if (node != null)
                {
                    // 查找 name="connString" 的 add 节点
                    XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@name='connString']");
                    if (addElem != null)
                    {
                        connStr = addElem.GetAttribute("connectionString");
                    }
                }
                */
                string connStr = ConfigurationManager.AppSettings["PlcIp"];
                return connStr;
            }
        }

        /// <summary>
        /// 执行 SQL 语句，返回受影响的行数。
        /// 适用于 INSERT、UPDATE、DELETE 等操作。
        /// </summary>
        /// <param name="sql">要执行的 SQL 语句。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>受影响的行数。</returns>
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] paras)
        {
            int count = 0;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                //调试，把数据库输出到调试窗口
                System.Diagnostics.Debug.WriteLine(conn.DataSource);
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras); //连接
                count = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            return count;
        }

        /// <summary>
        /// 执行查询，返回结果集中的第一行第一列的值。
        /// 适用于 COUNT、SUM 等聚合查询。
        /// </summary>
        /// <param name="sql">要执行的 SQL 查询语句。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>查询结果的第一行第一列的值；若无结果则返回 null。</returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] paras)
        {
            object result = null;
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                result = cmd.ExecuteScalar();
                cmd.Parameters.Clear();
            }
            return result;
        }

        /// <summary>
        /// 执行查询，返回一个 <see cref="SQLiteDataReader"/> 对象。
        /// 注意：调用方使用完毕后需要自行关闭 Reader（连接会随之关闭）。
        /// </summary>
        /// <param name="sql">要执行的 SQL 查询语句。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>SQLiteDataReader 对象。</returns>
        /// <exception cref="Exception">创建 DataReader 对象发生异常时抛出。</exception>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] paras)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
            try
            {
                // CommandBehavior.CloseConnection：关闭 Reader 时自动关闭连接
                SQLiteDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (SQLiteException ex)
            {
                conn.Close();
                throw new Exception("创建DataReader对象发生异常", ex);
            }
        }

        /// <summary>
        /// 执行查询，将结果填充到 <see cref="DataTable"/> 中。
        /// 适用于单结果集查询。
        /// </summary>
        /// <param name="sql">要执行的 SQL 查询语句。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>填充后的 DataTable。</returns>
        /// 使用：foreach (DataRow row in dt.Rows) 直接循环遍历每一行
        public static DataTable GetDataTable(string sql, params SQLiteParameter[] paras)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// 执行查询，将结果填充到 <see cref="DataSet"/> 中。
        /// 适用于返回多结果集的查询。
        /// </summary>
        /// <param name="sql">要执行的 SQL 查询语句。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>填充后的 DataSet。</returns>
        public static DataSet GetDataSet(string sql, params SQLiteParameter[] paras)
        {
            DataSet ds = new DataSet();
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteCommand cmd = BuilderCommand(conn, sql, null, paras);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 将 DataTable 中的更改更新到数据库。
        /// 针对于单表更新操作。
        /// </summary>
        /// <param name="dt">包含更改数据的 DataTable。</param>
        /// <param name="sql">用于查询数据的 SQL 语句（用于构建 CommandBuilder）。</param>
        /// <returns>更新操作影响的行数。</returns>
        public static int UpdateDataTable(DataTable dt, string sql)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
                SQLiteCommandBuilder cmdBuilder = new SQLiteCommandBuilder(da);
                return da.Update(dt);
            }
        }

        /// <summary>
        /// 执行事务，批量执行一系列 SQL 语句（不带参数）。
        /// 若中途出现异常则回滚事务。
        /// </summary>
        /// <param name="sqlList">要执行的 SQL 语句集合。</param>
        /// <returns>事务执行成功返回 true，否则抛出异常。</returns>
        /// <exception cref="Exception">事务执行出现异常时抛出。</exception>
        public static bool ExecuteTrans(List<string> sqlList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteTransaction tran = conn.BeginTransaction();
                SQLiteCommand cmd = BuilderCommand(conn, "", tran);
                try
                {
                    foreach (string sql in sqlList)
                    {
                        if (!string.IsNullOrEmpty(sql))
                        {
                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw new Exception("执行事务出现异常！", ex);
                }
            }
        }

        /// <summary>
        /// 执行事务，批量执行一系列操作（通过 <see cref="CommandInfo"/> 对象封装 SQL 及参数）。
        /// 若中途出现异常则回滚事务。
        /// </summary>
        /// <param name="comList">封装了 SQL 语句及参数的操作列表。</param>
        /// <returns>事务执行成功返回 true，否则抛出异常。</returns>
        /// <exception cref="Exception">事务执行出现异常时抛出。</exception>
        public static bool ExecuteTrans(List<CommandInfo> comList)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                SQLiteTransaction tran = conn.BeginTransaction();
                SQLiteCommand cmd = BuilderCommand(conn, "", tran);
                try
                {
                    foreach (CommandInfo com in comList)
                    {
                        cmd.CommandText = com.commandText;
                        cmd.CommandType = CommandType.Text;
                        if (com.paras != null && com.paras.Length > 0)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(com.paras);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    return true;
                }
                catch (SQLiteException ex)
                {
                    tran.Rollback();
                    throw new Exception("执行事务出现异常！", ex);
                }
            }
        }

        /// <summary>
        /// 执行事务，适用于需要按顺序执行、后一步依赖前一步结果的复杂操作。
        /// 通过传入一个委托，在事务上下文中执行自定义逻辑。
        /// </summary>
        /// <typeparam name="T">返回值类型。</typeparam>
        /// <param name="action">在事务上下文中执行的操作委托。</param>
        /// <returns>委托执行后的返回值。</returns>
        public static T ExecuteTrans<T>(Func<SQLiteCommand, T> action)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connString))
            {
                conn.Open();
                using (SQLiteTransaction trans = conn.BeginTransaction())
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.Transaction = trans;
                    try
                    {
                        T result = action(cmd);
                        trans.Commit();
                        return result;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// 统一构建 <see cref="SQLiteCommand"/> 对象的方法。
        /// 负责检查连接状态、绑定事务、添加参数等。
        /// </summary>
        /// <param name="conn">SQLite 连接对象，不能为 null。</param>
        /// <param name="sql">SQL 语句。</param>
        /// <param name="trans">SQLite 事务对象（可选）。</param>
        /// <param name="paras">SQL 参数数组（可选）。</param>
        /// <returns>构建好的 SQLiteCommand 对象。</returns>
        /// <exception cref="Exception">连接对象为 null 时抛出。</exception>
        private static SQLiteCommand BuilderCommand(SQLiteConnection conn, string sql, SQLiteTransaction trans, params SQLiteParameter[] paras)
        {
            if (conn == null)
                throw new Exception("连接对象不能为空！");

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);

            // 若连接处于关闭状态，则打开连接
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            // 绑定事务
            if (trans != null)
                cmd.Transaction = trans;

            // 添加参数
            if (paras != null && paras.Length > 0)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(paras);
            }

            return cmd;
        }
    }

    /// <summary>
    /// 封装一个数据库操作信息类，用于事务处理时传递 SQL 语句和参数。
    /// </summary>
    public class CommandInfo
    {
        /// <summary>
        /// SQL 语句或存储过程名。
        /// </summary>
        public string commandText;

        /// <summary>
        /// SQL 参数数组。
        /// </summary>
        public SQLiteParameter[] paras;

        /// <summary>
        /// 无参构造函数。
        /// </summary>
        public CommandInfo() { }

        /// <summary>
        /// 使用 SQL 语句构造操作信息对象。
        /// </summary>
        /// <param name="sql">SQL 语句或存储过程名。</param>
        public CommandInfo(string sql)
        {
            this.commandText = sql;
        }

        /// <summary>
        /// 使用 SQL 语句和参数构造操作信息对象。
        /// </summary>
        /// <param name="sql">SQL 语句或存储过程名。</param>
        /// <param name="_paras">SQL 参数数组。</param>
        public CommandInfo(string sql, params SQLiteParameter[] _paras)
        {
            paras = _paras;
            commandText = sql;
        }
    }
}