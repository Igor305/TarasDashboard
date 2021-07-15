using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItXRep
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
        public decimal SumCcWt { get; set; }
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
    }
}
