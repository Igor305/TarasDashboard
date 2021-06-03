using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrStockDate
    {
        public int StockId { get; set; }
        public int SrcPosId { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public byte ReasonOfMovingId { get; set; }
    }
}
