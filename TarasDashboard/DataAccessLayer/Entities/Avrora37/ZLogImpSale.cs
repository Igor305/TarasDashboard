using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogImpSale
    {
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public int? QtyAll { get; set; }
        public int? QtyNow { get; set; }
        public decimal? PercentDone { get; set; }
    }
}
