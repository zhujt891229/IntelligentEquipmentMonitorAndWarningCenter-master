using IEMAWC.DAL;
using IEMAWC.DAL.Base;
using IntelligentEquipmentMonitorAndWarningCenter;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IEMAWC.BLL
{
    public class ParaBLL
    {
       
        ParaDAL paraDAL = new ParaDAL();

        //获取实体类所有参数的方法
        public List<ParaInfo> GetAllParaList()
        {
            var paraList = paraDAL.GetParaDatas();
            foreach(var p in paraList)
            {
                int paraType = p.ParaType;
                p.ParaName = GetParaTypeName(paraType);
            }
            return paraList;
        }

        // 根据 typeId 获取参数名称
        private string GetParaTypeName(int typeId)
        {
            string typeName = "";
            switch (typeId)
            {
                case 0:
                    typeName = "实时数据";
                    break;
                case 1:
                    typeName = "灯珠状态";
                    break;
                case 2:
                    typeName = "历史数据";
                    break;
                default:
                    break;
            }
            return typeName;
        }


        //判断参数名是否存在
        public bool ExistParaName(string paraName)
        {
           
            return paraDAL.ExistParaName(paraName);
        }

        //根据功能码和寄存器地址判断地址是否存在
        public bool ExistByFuctionCodeAndAddress(byte functionCode, ushort address)
        {
            if(functionCode == 0 && address == 0) return false;

            return paraDAL.ExistByFuctionCodeAndAddress(functionCode, address);
        }

        //添加参数信息
        public int AddPara(ParaInfo para) 
        {
            if(para == null)
            {
                throw new Exception("参数信息为空 无法进行保存");
            }
            return paraDAL.AddPara(para);
        }

        // 修改参数信息
        public bool EditPara(ParaInfo para)
        {
            if (para == null) { throw new Exception("参数信息为空，无法进行修改"); }
            int count = paraDAL.EditPara(para);
            if (count > 0) return true;
            return false;
        }

        //删除多个参数信息
        public bool DeleteParas(List<int> idList)
        {
            return paraDAL.DeleteParas(idList);
        }

        //删除单个参数信息
        public bool DeletePara(int id)
        {
            int count = paraDAL.DeletePara(id);
            return count > 0 ? true : false;
        }

    }
}
