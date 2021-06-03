using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDisc
    {
        public RDisc()
        {
            RDiscChargeDs = new HashSet<RDiscChargeD>();
            RDiscChargeDts = new HashSet<RDiscChargeDt>();
            RDiscDcs = new HashSet<RDiscDc>();
            RDiscSaleDs = new HashSet<RDiscSaleD>();
            RDiscSaleDts = new HashSet<RDiscSaleDt>();
            RDiscSaleTs = new HashSet<RDiscSaleT>();
            RDiscSales = new HashSet<RDiscSale>();
            RDiscsTs = new HashSet<RDiscsT>();
            TLogDiscExpPs = new HashSet<TLogDiscExpP>();
            TLogDiscExps = new HashSet<TLogDiscExp>();
            TLogDiscRecTemps = new HashSet<TLogDiscRecTemp>();
            TLogDiscRecs = new HashSet<TLogDiscRec>();
            TempLogDiscRecs = new HashSet<TempLogDiscRec>();
            ZLogDiscExps = new HashSet<ZLogDiscExp>();
            ZLogDiscRecs = new HashSet<ZLogDiscRec>();
        }

        public long ChId { get; set; }
        public int DiscCode { get; set; }
        public string DiscName { get; set; }
        public bool ThisChargeOnly { get; set; }
        public bool ThisDocBonus { get; set; }
        public bool OtherDocsBonus { get; set; }
        public bool ChargeDcard { get; set; }
        public bool DiscOnlyWithDcard { get; set; }
        public bool ChargeAfterClose { get; set; }
        public int Priority { get; set; }
        public string AllowDiscs { get; set; }
        public string Shed1 { get; set; }
        public string Shed2 { get; set; }
        public string Shed3 { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool? GenProcs { get; set; }
        public bool? InUse { get; set; }
        public int DocCode { get; set; }
        public bool SimpleDisc { get; set; }
        public bool SaveDiscToDcard { get; set; }
        public bool SaveBonusToDcard { get; set; }
        public bool DiscFromDcard { get; set; }
        public bool ReProcessPosDiscs { get; set; }
        public string ValidOurs { get; set; }
        public string ValidStocks { get; set; }
        public bool AutoSelDiscs { get; set; }
        public string ShortCut { get; set; }
        public string Notes { get; set; }
        public bool GroupDisc { get; set; }
        public bool? PrintInCheque { get; set; }
        public bool AllowZeroPrice { get; set; }
        public bool AllowEditQty { get; set; }
        public bool RedistributeDiscSumInBusket { get; set; }

        public virtual ICollection<RDiscChargeD> RDiscChargeDs { get; set; }
        public virtual ICollection<RDiscChargeDt> RDiscChargeDts { get; set; }
        public virtual ICollection<RDiscDc> RDiscDcs { get; set; }
        public virtual ICollection<RDiscSaleD> RDiscSaleDs { get; set; }
        public virtual ICollection<RDiscSaleDt> RDiscSaleDts { get; set; }
        public virtual ICollection<RDiscSaleT> RDiscSaleTs { get; set; }
        public virtual ICollection<RDiscSale> RDiscSales { get; set; }
        public virtual ICollection<RDiscsT> RDiscsTs { get; set; }
        public virtual ICollection<TLogDiscExpP> TLogDiscExpPs { get; set; }
        public virtual ICollection<TLogDiscExp> TLogDiscExps { get; set; }
        public virtual ICollection<TLogDiscRecTemp> TLogDiscRecTemps { get; set; }
        public virtual ICollection<TLogDiscRec> TLogDiscRecs { get; set; }
        public virtual ICollection<TempLogDiscRec> TempLogDiscRecs { get; set; }
        public virtual ICollection<ZLogDiscExp> ZLogDiscExps { get; set; }
        public virtual ICollection<ZLogDiscRec> ZLogDiscRecs { get; set; }
    }
}
