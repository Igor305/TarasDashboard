using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCinvD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceAc { get; set; }
        public decimal SumAc { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal SumCcIn { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal GposTsumWt { get; set; }
        public decimal GposTtaxSum { get; set; }
    }
}
