using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCst
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
        public short PayDelay { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public short CurrId { get; set; }
        public byte DelId { get; set; }
        public decimal TsumAcIn { get; set; }
        public decimal TtrtAc { get; set; }
        public decimal TmoreCc { get; set; }
        public string Note1 { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public string IntDocId { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcIn { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }
    }
}
