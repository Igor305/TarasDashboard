using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPcost
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public int StockId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public short CurrId { get; set; }
        public decimal KursAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public int StateCode { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public decimal TnewTaxSum { get; set; }
        public int GposId { get; set; }
        public int GtaccId { get; set; }
        public decimal GtsumWt { get; set; }
        public decimal GttaxSum { get; set; }
        public decimal GtcorrSumWt { get; set; }
        public decimal GtcorrTaxSum { get; set; }
        public int GtadvAccId { get; set; }
        public decimal GtadvSumWt { get; set; }
        public decimal GtcorrAdvSumWt { get; set; }
        public decimal GtadvTaxSum { get; set; }
        public decimal GtcorrAdvTaxSum { get; set; }
        public decimal TexpCostCc { get; set; }
        public decimal TexpPosProdCostCc { get; set; }
        public decimal TexpPosCostCc { get; set; }
    }
}
