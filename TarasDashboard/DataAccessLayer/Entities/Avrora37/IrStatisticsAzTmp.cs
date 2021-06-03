using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrStatisticsAzTmp
    {
        public int Logid { get; set; }
        public DateTime? Datetime { get; set; }
        public string Dbname { get; set; }
        public string BaseSizeMb { get; set; }
        public string BaseFreeMb { get; set; }
        public string DataFreeMd { get; set; }
    }
}
