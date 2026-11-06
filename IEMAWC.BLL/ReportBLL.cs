using System.Data;
using IEMAWC.DAL;

namespace IEMAWC.BLL
{
    public class ReportBLL
    {
        private ReportDAL reportDAL = new ReportDAL();

        public int GetTotalCount(bool isAlarmReport, string reportType, string queryDate)
        {
            return reportDAL.GetTotalCount(isAlarmReport, reportType, queryDate);
        }

        public DataTable GetPageData(bool isAlarmReport, string reportType, string queryDate, int pageIndex, int pageSize)
        {
            return reportDAL.GetPageData(isAlarmReport, reportType, queryDate, pageIndex, pageSize);
        }

     
    }
}