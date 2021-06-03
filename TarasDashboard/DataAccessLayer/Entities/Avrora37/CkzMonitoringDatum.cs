using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class CkzMonitoringDatum
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string EmpName { get; set; }
        public int? Rows { get; set; }
        public int? Hours { get; set; }
        public int? Days { get; set; }
        public int? Units { get; set; }
    }
}
