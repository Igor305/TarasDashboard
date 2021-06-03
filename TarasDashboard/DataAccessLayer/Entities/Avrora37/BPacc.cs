using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPacc
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal Discount { get; set; }
        public short? PayDelay { get; set; }
        public string Notes { get; set; }
        public decimal? TranCc { get; set; }
        public decimal? MoreCc { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public int EmpId { get; set; }
        public string IntDocId { get; set; }
        public string CompAdd { get; set; }
        public int StateCode { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TsumCcIn { get; set; }
    }
}
