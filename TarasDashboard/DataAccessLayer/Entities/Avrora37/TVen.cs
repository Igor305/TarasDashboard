using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TVen
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public string IntDocId { get; set; }
        public int CompId { get; set; }
        public decimal Discount { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TnewTaxSum { get; set; }
        public decimal TnewSumCcWt { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }
        public int? Curator { get; set; }
        public short Cause { get; set; }
    }
}
