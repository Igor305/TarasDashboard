using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCinv1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public short CurrId { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursAc { get; set; }
        public decimal KursCc { get; set; }
        public string City { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public short? PayDelay { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal DtyCc { get; set; }
        public decimal PrcCc { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal? TranCc { get; set; }
        public decimal? MoreCc { get; set; }
        public decimal TsumAc { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TsumCcIn { get; set; }
        public decimal TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
    }
}
