using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSrecA
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal SetCostCc { get; set; }
        public decimal? SetValue1 { get; set; }
        public decimal? SetValue2 { get; set; }
        public decimal? SetValue3 { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal? Extra { get; set; }
        public decimal PriceCc { get; set; }
        public decimal NewPriceCcNt { get; set; }
        public decimal NewSumCcNt { get; set; }
        public decimal NewTax { get; set; }
        public decimal NewTaxSum { get; set; }
        public decimal NewPriceCcWt { get; set; }
        public decimal NewSumCcWt { get; set; }
        public long AchId { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
    }
}
