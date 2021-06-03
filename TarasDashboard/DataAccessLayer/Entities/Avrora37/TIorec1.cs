using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TIorec1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short CurrId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int DestStockId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public decimal TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public decimal? TnewSumMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public short PayDelay { get; set; }
        public DateTime? PayDocDate { get; set; }
        public int StateCode { get; set; }
    }
}
