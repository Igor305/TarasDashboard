using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TVenA
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal Tqty { get; set; }
        public decimal TnewQty { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TnewTaxSum { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public string BarCode { get; set; }
        public decimal Norma1 { get; set; }
        public int TsrcPosId { get; set; }
        public decimal PlpriceCc { get; set; }
        public decimal DiffPlsum { get; set; }
        public bool HandCorrected { get; set; }
        public int? Calculating { get; set; }
        public string Reasoncalc { get; set; }
        public decimal VenCorrectionQty { get; set; }
        public decimal? PriceCcNt { get; set; }
    }
}
