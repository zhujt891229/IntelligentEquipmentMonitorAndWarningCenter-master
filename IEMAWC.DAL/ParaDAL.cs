using Base;
using Helper;
using IEMAWC.DAL.Base;
using IntelligentEquipmentMonitorAndWarningCenter;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.DAL
{
    public class ParaDAL
    {

        //获取所有的参数
        public List<ParaInfo> GetParaDatas()
        {
            string cols = "ID,ParaName,FunctionCode,Address,DataType,DCount,Unit,Note,ParaType";
            string sql = $"select {cols}  from ParaInfos ";
            SQLiteDataReader dr = SQLiteHelper.ExecuteReader(sql);
            List<ParaInfo> paraList = new List<ParaInfo>();

            paraList = DbConvert.DataReaderToList<ParaInfo>(dr, cols);
            return paraList;

        }

        //判断参数名是否存在
        public bool ExistParaName(string paraName)
        {
            string strWhere = "ParaName=@ParaName";
            SQLiteParameter pName = new SQLiteParameter("@ParaName", paraName);
            return SQLiteQueryHelper.ExistByWhere("ParaInfos",strWhere,pName);
        }

        //根据功能码和寄存器地址判断地址是否存在
        public bool ExistByFuctionCodeAndAddress(byte functionCode,ushort address)
        {
            string strWhere = "FunctionCode=@functionCode and Address=@address";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@functionCode",functionCode),
                new SQLiteParameter("address",address)
            };
            return SQLiteQueryHelper.ExistByWhere("paraInfos",strWhere,paras);
        }

        //添加新的参数信息
        public int AddPara(ParaInfo para)
        {
            string sql = "insert into ParaInfos (ParaName,FunctionCode,Address,DataType,DCount,Unit,Note,ParaType) values " +
                "(@ParaName,@FunctionCode,@Address,@DataType,@DCount,@Unit,@Note,@ParaType);select last_insert_rowid()";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@ParaName",para.ParaName),
                new SQLiteParameter("@FunctionCode",para.FunctionCode),
                new SQLiteParameter("@Address",para.Address),
                new SQLiteParameter("@DataType",para.DataType),
                new SQLiteParameter("@DCount",para.DCount),
                new SQLiteParameter("@Unit",para.Unit),
                new SQLiteParameter("@Note",para.Note),
                new SQLiteParameter("@ParaType",para.ParaType)
             };
            object oldresult = SQLiteHelper.ExecuteScalar(sql, paras);
            if (oldresult != null && oldresult != DBNull.Value)
            {
                return Convert.ToInt32(oldresult);
            }
            return 0;
        }

        //修改参数信息
        public int EditPara(ParaInfo para)
        {
            string sql = "update ParaInfos set ParaName=@ParaName,FunctionCode=@FunctionCode,Address=@Address,DataType=@DataType,DCount=@DCount,Unit=@Unit,Note=@Note,ParaType=@ParaType where Id=@Id";
            SQLiteParameter[] paras =
            {
                new SQLiteParameter("@ParaName",para.ParaName),
                new SQLiteParameter("@FunctionCode",para.FunctionCode),
                new SQLiteParameter("@Address",para.Address),
                new SQLiteParameter("@DataType",para.DataType),
                new SQLiteParameter("@DCount",para.DCount),
                new SQLiteParameter("@Unit",para.Unit),
                new SQLiteParameter("@Note",para.Note),
                new SQLiteParameter("@ParaType",para.ParaType),
                new SQLiteParameter("@Id",para.Id)
            };
            int count = SQLiteHelper.ExecuteNonQuery(sql, paras);
            return count;
        }


        //删除多条参数信息，通过id
        public bool DeleteParas(List<int>idList)
        {
            string idStr = string.Join(",", idList);
            string sql = $"delete from ParaInfos where Id in ({idStr})";
            return SQLiteHelper.ExecuteTrans(new List<string>() { sql });
        }

        //删除单个参数信息
        public int DeletePara(int id) {
            string sql = $"delete from ParaInfos where id = {id}";
            int count = SQLiteHelper.ExecuteNonQuery(sql);
            return count;
        }

    }
}
