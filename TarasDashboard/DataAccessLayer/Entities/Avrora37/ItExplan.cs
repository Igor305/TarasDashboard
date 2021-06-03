using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItExplan
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public string Notes { get; set; }
        public int EmpId { get; set; }
        public int StateCode { get; set; }
        public short CodeId2 { get; set; }
        public int CompId { get; set; }
        public int SenderStockId { get; set; }
        public int ReasonId { get; set; }
        public int ReasonEmpId { get; set; }
        public int TransfertEmpId { get; set; }
        public DateTime? CheckQa { get; set; }
        public int DocCode { get; set; }
        public short CodeId4 { get; set; }
    }
}
