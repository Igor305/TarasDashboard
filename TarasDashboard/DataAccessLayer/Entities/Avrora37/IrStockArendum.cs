using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrStockArendum
    {
        public decimal QtyArendArea { get; set; }
        public int StockId { get; set; }
        public decimal QtySaleArea { get; set; }
        public decimal PriceArend { get; set; }
        public decimal SumArend { get; set; }
        public decimal NormRemAsumCc { get; set; }
        public decimal QtyStockArea { get; set; }
        public decimal QtyRack { get; set; }
    }
}
