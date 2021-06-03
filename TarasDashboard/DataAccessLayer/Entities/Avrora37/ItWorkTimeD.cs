using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItWorkTimeD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public DateTime? DayBtime { get; set; }
        public DateTime? DayEtime { get; set; }
        public decimal FactTime { get; set; }
        public string Notes { get; set; }
        public int SrcposId { get; set; }
    }
}
