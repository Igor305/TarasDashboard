using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItProdsInTransitD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public string BarCode { get; set; }
        public string Notes { get; set; }
        public short CodeId4 { get; set; }
        public string Article4 { get; set; }
    }
}
