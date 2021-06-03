using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStockSub
    {
        public int StockId { get; set; }
        public int SubStockId { get; set; }
        public short DepId { get; set; }
    }
}
