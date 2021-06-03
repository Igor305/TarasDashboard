using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCosD
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
        public decimal? NewQty { get; set; }
        public decimal? NewPriceCcIn { get; set; }
        public decimal? NewSumCcIn { get; set; }
        public decimal? Extra { get; set; }
        public decimal? NewPriceCc { get; set; }
        public decimal? CostSumT { get; set; }
        public decimal? CostPercent { get; set; }
        public decimal? CostSum { get; set; }
        public decimal? CostCc { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
    }
}
