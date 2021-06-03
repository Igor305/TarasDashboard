using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCst21
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public short CurrId { get; set; }
        public string City { get; set; }
        public decimal? TsumAc { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TtaxSum { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal TtrtAc { get; set; }
        public decimal TtrtCc { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public short? PayDelay { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal KursCc { get; set; }
        public decimal TsumAcIn { get; set; }
    }
}
