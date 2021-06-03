using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class CEmpExp
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public string AccountAc { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public int StockId { get; set; }
        public int EmpId { get; set; }
        public short CurrId { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public decimal SumAc { get; set; }
        public string Subject { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int StateCode { get; set; }
        public string SrcDocId { get; set; }
        public DateTime SrcDocDate { get; set; }
        public string IntDocId { get; set; }
    }
}
