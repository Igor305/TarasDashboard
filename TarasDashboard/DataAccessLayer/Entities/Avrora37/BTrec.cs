using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BTrec
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public string Notes { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public int DocType { get; set; }
        public decimal GtsumWt { get; set; }
        public decimal GttaxSum { get; set; }
        public int GtaccId { get; set; }
        public byte PosType { get; set; }
        public byte TaxType { get; set; }
        public bool TaxCredit { get; set; }
        public DateTime? PayDate { get; set; }
        public string PayForm { get; set; }
        public bool? TakeTotalCosts { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public int GposId { get; set; }
        public decimal GtcorrSumWt { get; set; }
        public decimal GtcorrTaxSum { get; set; }
        public bool IsCorrection { get; set; }
        public int GtadvAccId { get; set; }
        public decimal GtadvSumWt { get; set; }
        public decimal GtcorrAdvSumWt { get; set; }
        public decimal GtadvTaxSum { get; set; }
        public decimal GtcorrAdvTaxSum { get; set; }
        public decimal SumCcNt20 { get; set; }
        public decimal TaxSum20 { get; set; }
        public decimal SumCcNt0 { get; set; }
        public decimal TaxSum0 { get; set; }
        public decimal SumCcNtFree { get; set; }
        public decimal TaxSumFree { get; set; }
        public decimal SumCcNtNo { get; set; }
        public decimal TaxSumNo { get; set; }
        public byte TaxCorrType { get; set; }
        public decimal SumCcNt7 { get; set; }
        public decimal TaxSum7 { get; set; }
    }
}
