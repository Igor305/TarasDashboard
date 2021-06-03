using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BLrecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public decimal ChargeCc { get; set; }
        public decimal SickCc { get; set; }
        public decimal InsureCc { get; set; }
        public decimal LeaveCc { get; set; }
        public decimal NleaveCc { get; set; }
        public decimal MhelpCc { get; set; }
        public decimal PregCc { get; set; }
        public decimal? MchargeCc { get; set; }
        public decimal? MchargeCc1 { get; set; }
        public decimal? MchargeCc2 { get; set; }
        public decimal AdvanceCc { get; set; }
        public decimal AlimonyCc { get; set; }
        public decimal PensionTaxCc { get; set; }
        public decimal IncomeTaxCc { get; set; }
        public decimal InsureTaxCc { get; set; }
        public decimal UnionCc { get; set; }
        public decimal CrateCc { get; set; }
        public decimal LoanCc { get; set; }
        public decimal EmpTaxCc { get; set; }
        public byte WorkDays { get; set; }
        public byte SickDays { get; set; }
        public decimal? MoreCc { get; set; }
        public decimal? MoreCc1 { get; set; }
        public decimal? MoreCc2 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal TuniSocDedСс { get; set; }
        public decimal TuniSocChargeСс { get; set; }
        public decimal UniSocDedСс { get; set; }
        public decimal UniSocChargeСс { get; set; }
        public decimal UniSocDedContractsCc { get; set; }
        public decimal UniSocChargeContractsСс { get; set; }
        public decimal UniSocDedSickCc { get; set; }
        public decimal UniSocChargeSickСс { get; set; }
    }
}
