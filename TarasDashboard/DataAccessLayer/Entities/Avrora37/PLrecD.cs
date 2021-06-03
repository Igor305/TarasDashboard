using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLrecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public long AchId { get; set; }
        public decimal MainSumCc { get; set; }
        public decimal ExtraSumCc { get; set; }
        public decimal MoreSumCc { get; set; }
        public decimal NeglibleSumCc { get; set; }
        public decimal DeductionSumCc { get; set; }
        public decimal BtotPensCc { get; set; }
        public decimal BtotUnEmployCc { get; set; }
        public decimal BtotSocInsureCc { get; set; }
        public decimal BtotAccidentCc { get; set; }
        public decimal BincomeTaxCc { get; set; }
        public decimal BpensCc { get; set; }
        public decimal BunEmployCc { get; set; }
        public decimal BsocInsureCc { get; set; }
        public decimal TotPensCc { get; set; }
        public decimal TotUnEmployCc { get; set; }
        public decimal TotSocInsureCc { get; set; }
        public decimal TotAccidentCc { get; set; }
        public decimal IncomeTaxCc { get; set; }
        public decimal PensCc { get; set; }
        public decimal UnEmployCc { get; set; }
        public decimal SocInsureCc { get; set; }
        public decimal ChargeSumCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal Bindexing { get; set; }
        public int BprivIncomeTax { get; set; }
        public short DetSubId { get; set; }
        public short DetDepId { get; set; }
        public decimal CrateCc { get; set; }
        public decimal TpensCccor { get; set; }
        public decimal TunEmployCccor { get; set; }
        public decimal TsocInsureCccor { get; set; }
        public decimal TincomeTaxCccor { get; set; }
        public decimal TtotPensCccor { get; set; }
        public decimal TtotSocInsureCccor { get; set; }
        public decimal TtotUnEmployCccor { get; set; }
        public decimal TtotAccidentCccor { get; set; }
        public decimal UniSocChargeСс { get; set; }
        public decimal UniSocDedСс { get; set; }
        public decimal TuniSocChargeСсcor { get; set; }
        public decimal TuniSocDedСсcor { get; set; }
        public decimal BuniSocChargeСс { get; set; }
        public decimal BuniSocDedСс { get; set; }
        public decimal MilitaryTaxCc { get; set; }
        public decimal TmilitaryTaxCccor { get; set; }
        public decimal BmilitaryTaxCc { get; set; }
    }
}
