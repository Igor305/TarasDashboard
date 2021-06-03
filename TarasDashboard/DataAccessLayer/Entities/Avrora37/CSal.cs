using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class CSal
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public DateTime DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int StateCode { get; set; }
        public decimal CashSumAc { get; set; }
        public decimal PlanSumCc1 { get; set; }
        public decimal PlanSumCc2 { get; set; }
        public decimal PlanSumCc3 { get; set; }
        public decimal ChargeRate1 { get; set; }
        public decimal ChargeRate2 { get; set; }
        public decimal ChargeRate3 { get; set; }
        public decimal ShortageCc { get; set; }
        public DateTime VenBdate { get; set; }
        public DateTime VenEdate { get; set; }
        public decimal CashVenAc { get; set; }
        public decimal TsumAc { get; set; }
        public decimal OutAc { get; set; }
    }
}
