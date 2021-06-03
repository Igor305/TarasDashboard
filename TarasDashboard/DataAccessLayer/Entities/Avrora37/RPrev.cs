using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPrev
    {
        public long ChId { get; set; }
        public int PrevId { get; set; }
        public string PrevFiscId { get; set; }
        public string PrevName { get; set; }
        public string PrevDocId { get; set; }
        public string PrevDocItem { get; set; }
        public string PrevDocPoint { get; set; }
        public string PrevDocPart { get; set; }
        public short NoTaxMin { get; set; }
        public decimal UseTotPensFundPrc { get; set; }
        public decimal UseTotUnEmployPrc { get; set; }
        public decimal UseTotSocInsurePrc { get; set; }
        public decimal UseTotAccidentPrc { get; set; }
        public decimal UseIncomeTaxPrc { get; set; }
        public decimal UsePensFundPrc { get; set; }
        public decimal UseUnEmployPrc { get; set; }
        public decimal UseSocInsurePrc { get; set; }
        public string Notes { get; set; }
        public decimal SickPayPrc { get; set; }
        public decimal UseIncomeTaxReliefPrc { get; set; }
    }
}
