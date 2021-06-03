using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStockG
    {
        public long ChId { get; set; }
        public short StockGid { get; set; }
        public string StockGname { get; set; }
        public string Notes { get; set; }
    }
}
