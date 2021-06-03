using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSale
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
        public string Notes { get; set; }
        public short Crid { get; set; }
        public int OperId { get; set; }
        public string CreditId { get; set; }
        public DateTime DocTime { get; set; }
        public int EmpId { get; set; }
        public string IntDocId { get; set; }
        public decimal CashSumCc { get; set; }
        public decimal ChangeSumCc { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public int StateCode { get; set; }
        public int DeskCode { get; set; }
        public int? Visitors { get; set; }
        public decimal TpurSumCcNt { get; set; }
        public decimal TpurTaxSum { get; set; }
        public decimal TpurSumCcWt { get; set; }
        public DateTime? DocCreateTime { get; set; }
        public decimal TrealSum { get; set; }
        public decimal TlevySum { get; set; }
        public int Wpid { get; set; }
        public long DcardChId { get; set; }

        public virtual RDcard DcardCh { get; set; }
    }
}
