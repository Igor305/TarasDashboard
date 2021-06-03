using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BCexp1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal TsumAc { get; set; }
        public decimal TsumCc { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal? TsumMc { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string City { get; set; }
        public string Subject { get; set; }
        public int EmpId { get; set; }
        public int CashEmpId { get; set; }
        public string EmpName { get; set; }
        public short CurrId { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
