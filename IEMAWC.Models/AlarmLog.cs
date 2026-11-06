using System;

namespace IEMAWC.DAL
{
    // 报警信息实体类，对应数据库表
    public class AlarmLog
    {
        public int LogId { get; set; }            // 主键自增，插入时通常不需要赋值
        public int InfoType { get; set; }         // 报警类型 0 温度，1 湿度，2 亮度
        public string AlarmTime { get; set; }     // 报警时间
        public int AlarmType { get; set; }        // 报警类型，0 为实时报警，1 为历史报警
        public string AlarmState { get; set; }    // 报警状态 1 为高值异常，0 为低值异常
        public double AlarmValue { get; set; }    // 报警数据值
        public string AlarmNote { get; set; }     // 报警描述
    }
}