using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BSrepDp
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int StockId { get; set; }
        public short PcodeId1 { get; set; }
        public short PcodeId2 { get; set; }
        public short PcodeId3 { get; set; }
        public short PcodeId4 { get; set; }
        public short PcodeId5 { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
