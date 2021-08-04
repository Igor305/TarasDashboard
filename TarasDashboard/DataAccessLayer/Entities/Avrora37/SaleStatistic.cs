using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class SaleStatistic
    {
        public DateTime DateOfData { get; set; }
        public decimal? TsumCcWt { get; set; }
        public decimal? AvgCheck { get; set; }
        public decimal? Rec { get; set; }
        public decimal? Margin { get; set; }
        public decimal? Turnover { get; set; }
        public decimal? Lfl { get; set; }
    }
}
