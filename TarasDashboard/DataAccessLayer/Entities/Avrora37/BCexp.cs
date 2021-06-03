using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCexp
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public string CompTxt { get; set; }
        public string Subject { get; set; }
        public string Appx { get; set; }
        public string ByDoc { get; set; }
        public short CurrId { get; set; }
        public decimal SumAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public int EmpId { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal GtsumWt { get; set; }
        public decimal GttaxSum { get; set; }
        public int GtaccId { get; set; }
        public string Notes { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public int CashEmpId { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public int GposId { get; set; }
        public decimal GtcorrSumWt { get; set; }
        public decimal GtcorrTaxSum { get; set; }
        public int GtadvAccId { get; set; }
        public decimal GtadvSumWt { get; set; }
        public decimal GtcorrAdvSumWt { get; set; }
        public decimal GtadvTaxSum { get; set; }
        public decimal GtcorrAdvTaxSum { get; set; }
    }
}
