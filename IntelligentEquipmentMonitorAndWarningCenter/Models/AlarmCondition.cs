using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.IntelligentDeviceMonitorAndWarningCenter.Models
{
    public class AlarmCondition
    {
        public string ConditionType {  get; set; }
        public string Unit {  get; set; }
        public double MinValue {  get; set; }
        public double MaxValue { get; set; }
    }
}
