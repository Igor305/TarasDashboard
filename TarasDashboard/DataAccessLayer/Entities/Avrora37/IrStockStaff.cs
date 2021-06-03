using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrStockStaff
    {
        public int StockId { get; set; }
        public int PostId { get; set; }
        public decimal NormTime { get; set; }
        public decimal Wrate { get; set; }
        public decimal? ExtraWrate { get; set; }
    }
}
