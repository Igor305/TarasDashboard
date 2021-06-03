using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BRecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal CostSum { get; set; }
        public decimal CostCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal Extra { get; set; }
        public decimal PriceCc { get; set; }
        public decimal GposTsumWt { get; set; }
        public decimal GposTtaxSum { get; set; }
    }
}
