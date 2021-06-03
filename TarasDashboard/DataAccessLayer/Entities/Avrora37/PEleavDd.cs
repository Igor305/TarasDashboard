using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEleavDd
    {
        public long AchId { get; set; }
        public DateTime SrcDate { get; set; }
        public decimal DaysNorm { get; set; }
        public decimal DaysFact { get; set; }
        public decimal FactSalary { get; set; }
    }
}
