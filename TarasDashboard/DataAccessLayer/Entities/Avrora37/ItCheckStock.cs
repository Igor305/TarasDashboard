using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCheckStock
    {
        public int? Stockid { get; set; }
        public DateTime? CheckDate { get; set; }
        public decimal? SumQty { get; set; }
    }
}
