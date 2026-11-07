using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.Models
{
    public class UserInfo
    {
        //数据库字段应该对应或者映射
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public int UserState { get; set; }

    }
}
