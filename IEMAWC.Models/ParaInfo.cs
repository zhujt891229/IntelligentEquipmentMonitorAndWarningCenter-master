using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentEquipmentMonitorAndWarningCenter
{
    public class ParaInfo
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Id { get; set; }
        public string ParaName { get; set; }
        public byte FunctionCode { get; set; }
        public ushort Address { get; set; }
        public string DataType { get; set; }

        public int DCount { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public int ParaType { get; set; }

        public string ParaTypeName { get; set; }
    }
}
