using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDeskRe
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DocTime { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int EmpId { get; set; }
        public int DeskCode { get; set; }
        public DateTime ResTime { get; set; }
        public int Visitors { get; set; }
        public string Notes { get; set; }
        public DateTime? ResTimeEnd { get; set; }
        public decimal SumPrePay { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int CompId { get; set; }
        public decimal KursMc { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public int PersonId { get; set; }
    }
}
