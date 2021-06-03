using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDi
    {
        public TDi()
        {
            TDisRoutes = new HashSet<TDisRoute>();
            TDisSpends = new HashSet<TDisSpend>();
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
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public DateTime? NotDate { get; set; }
        public bool NotSn { get; set; }
        public string IntDocId { get; set; }
        public short CurrId { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int WteamId { get; set; }
        public int Merchant { get; set; }
        public DateTime? Dateproc { get; set; }
        public DateTime? Dateproc2 { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public DateTime? PlanProcDate { get; set; }
        public DateTime? DistrCheckDate { get; set; }
        public DateTime? PrintDate { get; set; }
        public DateTime? ShedLoadDate { get; set; }
        public DateTime? GiveDateOnPpw { get; set; }
        public int? GivePpwempId { get; set; }
        public int? WteamIdppw { get; set; }
        public DateTime? DateOfDeliveryPpw { get; set; }
        public int? AccPpwempId { get; set; }
        public DateTime? GiveDateOnOps { get; set; }
        public int? GiveOpsempId { get; set; }
        public int? WteamIdops { get; set; }
        public DateTime? DateOfDeliveryOps { get; set; }
        public int? AccOpsempId { get; set; }

        public virtual ICollection<TDisRoute> TDisRoutes { get; set; }
        public virtual ICollection<TDisSpend> TDisSpends { get; set; }
    }
}
