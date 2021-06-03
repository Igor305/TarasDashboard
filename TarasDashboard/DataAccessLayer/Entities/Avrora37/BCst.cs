using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCst
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public short? PayDelay { get; set; }
        public string Notes { get; set; }
        public short CurrId { get; set; }
        public byte DelId { get; set; }
        public decimal TsumAcIn { get; set; }
        public decimal TtrtAc { get; set; }
        public decimal TmoreCc { get; set; }
        public string Note1 { get; set; }
        public decimal GtsumWt { get; set; }
        public decimal GttaxSum { get; set; }
        public int GtaccId { get; set; }
        public string IntDocId { get; set; }
        public string CompAdd { get; set; }
        public int StateCode { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcIn { get; set; }
        public int GposId { get; set; }
        public decimal GtcorrSumWt { get; set; }
        public decimal GtcorrTaxSum { get; set; }
        public int CstCompId { get; set; }
        public decimal TcstSumCccor { get; set; }
        public decimal TtrtCc { get; set; }
        public decimal KursAcIn { get; set; }
        public int GtadvAccId { get; set; }
        public decimal GtadvSumWt { get; set; }
        public decimal GtcorrAdvSumWt { get; set; }
        public decimal GtadvTaxSum { get; set; }
        public decimal GtcorrAdvTaxSum { get; set; }
        public string CstDocCode { get; set; }
    }
}
