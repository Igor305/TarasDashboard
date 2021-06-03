using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStock
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public short StockGid { get; set; }
        public string Notes { get; set; }
        public int Plid { get; set; }
        public int EmpId { get; set; }
        public bool IsWholesale { get; set; }
        public string Address { get; set; }
        public bool? UseInRems { get; set; }
        public bool? IsTradeArea { get; set; }
        public int Amid { get; set; }
        public int? StockTaxId { get; set; }
        public decimal PlanSumCc1 { get; set; }
        public decimal PlanSumCc2 { get; set; }
        public decimal PlanSumCc3 { get; set; }
        public decimal ChargeRate1 { get; set; }
        public decimal ChargeRate2 { get; set; }
        public decimal ChargeRate3 { get; set; }
        public decimal DisOpenFactor { get; set; }
        public decimal OverRems { get; set; }
        public int CityId { get; set; }
        public decimal? PlanSumCcstock { get; set; }
        public int RegionId { get; set; }
        public bool? UseCards { get; set; }
        public bool? TransitStock { get; set; }
        public bool? MobAccept { get; set; }
        public decimal? LimitNeed { get; set; }
        public int? Rmempid { get; set; }
        public int? Tmempid { get; set; }
        public short? HeatingCode { get; set; }
        public int VenPeriod { get; set; }
        public decimal? LimitPpe { get; set; }
        public bool DenyFreeRet { get; set; }
        public bool? CancelCheque { get; set; }
        public bool? DenyEditQty { get; set; }
        public bool? DenyBargChipRet { get; set; }
        public short StockAttribute { get; set; }
        public byte? FormatTtid { get; set; }
    }
}
