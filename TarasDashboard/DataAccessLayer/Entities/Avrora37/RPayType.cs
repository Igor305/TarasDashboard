using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPayType
    {
        public long ChId { get; set; }
        public short PayTypeId { get; set; }
        public short PayTypeCatId { get; set; }
        public string PayTypeName { get; set; }
        public string Notes { get; set; }
        public bool UseTotPensFund { get; set; }
        public bool UseTotUnEmploy { get; set; }
        public bool UseTotSocInsure { get; set; }
        public bool UseTotAccident { get; set; }
        public bool UseIncomeTax { get; set; }
        public bool UsePensFund { get; set; }
        public bool UseUnEmploy { get; set; }
        public bool UseSocInsure { get; set; }
        public bool GrossOutlay { get; set; }
        public byte FundType { get; set; }
        public string SrcDocFilterR { get; set; }
        public string SrcDocFilterE { get; set; }
        public string SrcDocExpR { get; set; }
        public string SrcDocExpE { get; set; }
        public bool IsDeduction { get; set; }
        public bool UseToIndexing { get; set; }
        public bool UsePrivIncomeTax { get; set; }
        public bool UseInSick { get; set; }
        public bool UseInLeav { get; set; }
        public bool UseInTrn { get; set; }
        public string SrcDocTypeR { get; set; }
        public string SrcDocTypeE { get; set; }
        public string DocDateFieldR { get; set; }
        public string DocDateFieldE { get; set; }
        public bool UseInDisPay { get; set; }
        public bool UseInMainSalaryType { get; set; }
        public bool UseInAdvanceSalaryType { get; set; }
        public bool UseInLeavSalaryType { get; set; }
        public bool UseInPregSick { get; set; }
        public string UniSocChargeRateExpR { get; set; }
        public string UniSocChargeRateExpE { get; set; }
        public string UniSocDedRateExpR { get; set; }
        public string UniSocDedRateExpE { get; set; }
        public int UniSocPriority { get; set; }
        public string BincomeTaxExpE { get; set; }
        public string BincomeTaxExpR { get; set; }
        public bool UseMilitaryTax { get; set; }
    }
}
