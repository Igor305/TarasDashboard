using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TZRep
    {
        public long ChId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public short Crid { get; set; }
        public int OperId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string FacId { get; set; }
        public string FinId { get; set; }
        public int ZrepNum { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal SumA { get; set; }
        public decimal SumB { get; set; }
        public decimal SumC { get; set; }
        public decimal SumD { get; set; }
        public decimal RetSumA { get; set; }
        public decimal RetSumB { get; set; }
        public decimal RetSumC { get; set; }
        public decimal RetSumD { get; set; }
        public decimal SumCash { get; set; }
        public decimal SumCard { get; set; }
        public decimal SumCredit { get; set; }
        public decimal SumCheque { get; set; }
        public decimal SumOther { get; set; }
        public decimal RetSumCash { get; set; }
        public decimal RetSumCard { get; set; }
        public decimal RetSumCredit { get; set; }
        public decimal RetSumCheque { get; set; }
        public decimal RetSumOther { get; set; }
        public decimal SumMonRec { get; set; }
        public decimal SumMonExp { get; set; }
        public decimal? SumRem { get; set; }
        public string Notes { get; set; }
        public decimal SumE { get; set; }
        public decimal SumF { get; set; }
        public decimal RetSumE { get; set; }
        public decimal RetSumF { get; set; }
        public decimal? TaxA { get; set; }
        public decimal? TaxB { get; set; }
        public decimal? TaxC { get; set; }
        public decimal? TaxD { get; set; }
        public decimal? TaxE { get; set; }
        public decimal? TaxF { get; set; }
        public decimal? RetTaxA { get; set; }
        public decimal? RetTaxB { get; set; }
        public decimal? RetTaxC { get; set; }
        public decimal? RetTaxD { get; set; }
        public decimal? RetTaxE { get; set; }
        public decimal? RetTaxF { get; set; }
    }
}
