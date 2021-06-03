using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TIorec
    {
        public TIorec()
        {
            TIorecRoutes = new HashSet<TIorecRoute>();
            TIorecSpends = new HashSet<TIorecSpend>();
        }

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
        public short PayDelay { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public DateTime? ExpDate { get; set; }
        public bool ExpSn { get; set; }
        public DateTime? NotDate { get; set; }
        public bool NotSn { get; set; }
        public short SupplyDayCount { get; set; }
        public string IntDocId { get; set; }
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
        public int DestStockId { get; set; }
        public DateTime? FinishDate { get; set; }

        public virtual ICollection<TIorecRoute> TIorecRoutes { get; set; }
        public virtual ICollection<TIorecSpend> TIorecSpends { get; set; }
    }
}
