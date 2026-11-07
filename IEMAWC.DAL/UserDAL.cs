using Base;
using Helper;
using IEMAWC.DAL.Helper;
using IEMAWC.Models;
using IntelligentEquipmentMonitorAndWarningCenter;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.DAL
{
    public class UserDAL
    {
        // 查询是否存在用户，存在返回值大于0 不存在返回 0 
        public int ExistLoginUser(UserInfo user)
        {
            /*
            //编写sql 语句
            string sql = "select count(1) from UserInfos where UserName = @userName and UserPwd = @userPwd and UserState = 1";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@userName", user.UserName),
                new SQLiteParameter("@userPwd", user.UserPwd)
            };

            //object oCount = SQLiteHelper.ExecuteNonQuery(sql, paras);  //返回查询到的数量 返回 int 
            object oCount = SQLiteHelper.ExecuteScalar(sql, paras);      // 返回查询到的第一行第一列，返回obj
            if (oCount!=null && oCount.ToString() != "")
            {
                int count = Convert.ToInt32(oCount); // 把obj 对象转换为int 类型，函数返回值是int
                return count;
            }
            return 0;
            */
            return SQLHelper.Instance.Queryable<UserInfo>().Where(it => it.UserName == user.UserName && it.UserPwd == user.UserPwd && it.UserState == 1).Count();
        }

       

    }
}
