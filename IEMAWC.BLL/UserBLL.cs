using IEMAWC.DAL;
using IEMAWC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.BLL
{
    public class UserBLL
    {
        private UserDAL userDAL = new UserDAL();

        //登录的业务层
        public bool LoginSystem(string userName, string userPwd)
        {
            //创建新的user 对象
            
            UserInfo user = new UserInfo()
            {
                UserName = userName,
                UserPwd = userPwd
            };
            int count = userDAL.ExistLoginUser(user);
            return count > 0;
        }
    }
}
