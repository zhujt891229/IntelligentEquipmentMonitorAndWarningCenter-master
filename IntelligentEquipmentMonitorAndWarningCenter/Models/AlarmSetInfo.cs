using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.IntelligentDeviceMonitorAndWarningCenter.Models
{
    public class AlarmSetInfo
    {
        public List<AlarmCondition> Conditions { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
