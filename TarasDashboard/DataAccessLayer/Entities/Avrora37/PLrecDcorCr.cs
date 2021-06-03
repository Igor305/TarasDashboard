using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLrecDcorCr
    {
        public long AchId { get; set; }
        public short YearId { get; set; }
        public short MonthId { get; set; }
        public decimal PensCccor { get; set; }
        public decimal UnEmployCccor { get; set; }
        public decimal SocInsureCccor { get; set; }
        public decimal IncomeTaxCccor { get; set; }
        public decimal TotPensCccor { get; set; }
        public decimal TotSocInsureCccor { get; set; }
        public decimal TotUnEmployCccor { get; set; }
        public decimal TotAccidentCccor { get; set; }
        public decimal UniSocChargeСсcor { get; set; }
        public decimal UniSocDedСсcor { get; set; }
        public int DetSrcPosId { get; set; }
        public string Notes { get; set; }
        public decimal MilitaryTaxCccor { get; set; }
    }
}
