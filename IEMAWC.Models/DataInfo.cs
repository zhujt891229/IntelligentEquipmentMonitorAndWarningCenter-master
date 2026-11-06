using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEMAWC.DAL
{
    public class DataInfo
    {
        public int Id { get; set; }
        public string CollectionTime { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Brightness { get; set; }
    }
}
