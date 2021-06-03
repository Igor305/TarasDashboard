using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TAcc
    {
        public TAcc()
        {
            TAccRoutes = new HashSet<TAccRoute>();
            TAccSpends = new HashSet<TAccSpend>();
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
        public bool ReserveProds { get; set; }
        public byte ReserveDayCount { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string IntDocId { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }

        public virtual ICollection<TAccRoute> TAccRoutes { get; set; }
        public virtual ICollection<TAccSpend> TAccSpends { get; set; }
    }
}
