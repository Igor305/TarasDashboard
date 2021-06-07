using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.Entities
{
    [Keyless]
    public class IpSaleStatistic
    {
        public DateTime? DateOfData { get; set; }
        public decimal? TSumCC_wt { get; set; }
        public decimal? AvgCheck { get; set; }
        public decimal? Rec { get; set; }
        public decimal? Margin { get; set; }
        public decimal? Turnover { get; set; }
    }
}
