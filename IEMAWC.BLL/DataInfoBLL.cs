using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEMAWC.DAL;

namespace IEMAWC.BLL
{
    public class DataInfoBLL
    {
        
        private readonly DataInfoDAL dataInfoDAL = new DataInfoDAL();

        //插入一条数据
        public int InsertData(DataInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            if (string.IsNullOrWhiteSpace(info.CollectionTime))
                throw new ArgumentException("采集时间不能为空！", nameof(info));

            if (info.Humidity < 0 || info.Humidity > 100)
                throw new ArgumentException("湿度值不合法，应在 0~100 之间！", nameof(info));

            if (info.Brightness < 0)
                throw new ArgumentException("亮度值不能为负！", nameof(info));

            return dataInfoDAL.InsertDataToDataInfos(info);
        }


        //获取最新的十条信息
        /// <summary>
        /// 获取最新日期的前 10 条数据。
        /// </summary>
        public BindingList<DataInfo> GetTenNewData()
        {
            return dataInfoDAL.GetTenNewDataFromDataInfos();
        }

        /// <summary>
        /// 获取指定时间段内的采集数据
        /// </summary>
        public List<DataInfo> GetDataInfos(DateTime start, DateTime end)
        {
            return dataInfoDAL.GetDataInfos(start, end);
        }

        /// <summary>
        /// 获取最近N条采集数据
        /// </summary>
        public List<DataInfo> GetLatestDataInfos(int count)
        {
            return dataInfoDAL.GetLatestDataInfos(count);
        }


        /// <summary>
        /// 分页获取指定时间段内的采集数据
        /// </summary>
        public List<DataInfo> GetDataInfosByPage(DateTime start, DateTime end, int pageIndex, int pageSize)
        {
            return dataInfoDAL.GetDataInfosByPage(start, end, pageIndex, pageSize);
        }

        /// <summary>
        /// 获取指定时间段内的采集次数
        /// </summary>
        public int GetDataCount(DateTime start, DateTime end)
        {
            return dataInfoDAL.GetDataCount(start, end);
        }

        /// <summary>
        /// 获取指定时间段内的平均温度、平均湿度、平均亮度
        /// </summary>
        public (double avgT, double avgH, double avgB) GetDataAverage(DateTime start, DateTime end)
        {
            return dataInfoDAL.GetDataAverage(start, end);
        }

    }
}
