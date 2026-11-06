using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEMAWC.DAL;
using NPOI.SS.Formula.Functions;

namespace IEMAWC.BLL
{

    
    public class AlarmInfoBLL
    {
        private readonly AlarmLogDAL alarmLogDAL = new AlarmLogDAL();

        //public DataTable QueryLegalData(dt)
        //{

        //    return alarmLogDAL.QueryLegalData(dt);
        //}


        public int GetTotalCount(int alarmType, List<string> states, int infoType, string startStr, string endStr)
        {
            return alarmLogDAL.GetTotalCount(alarmType, states, infoType, startStr, endStr);
        }

        public DataTable GetAlarmList(int alarmType, List<string> states, int infoType, string startStr, string endStr, int pageIndex, int pageSize)
        {
            return alarmLogDAL.GetList(alarmType, states, infoType, startStr, endStr, pageIndex, pageSize);
        }

        public bool DeleteAlarmLogs(List<long> ids)
        {
            return alarmLogDAL.DeleteByIds(ids) > 0;
        }

    }
}
