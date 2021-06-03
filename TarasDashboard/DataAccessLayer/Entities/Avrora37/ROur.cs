using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ROur
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public string OurName { get; set; }
        public string Address { get; set; }
        public string PostIndex { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Code { get; set; }
        public string TaxRegNo { get; set; }
        public string TaxCode { get; set; }
        public string OurDesc { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string OurShort { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string Job1 { get; set; }
        public string Job2 { get; set; }
        public string Job3 { get; set; }
        public DateTime? DayBtime { get; set; }
        public DateTime? DayEtime { get; set; }
        public DateTime? EvenBtime { get; set; }
        public DateTime? EvenEtime { get; set; }
        public decimal EvenPayFac { get; set; }
        public DateTime? NightBtime { get; set; }
        public DateTime? NightEtime { get; set; }
        public decimal NightPayFac { get; set; }
        public decimal OverPayFactor { get; set; }
        public string ActType { get; set; }
        public string FinForm { get; set; }
        public string PropForm { get; set; }
        public string EcActType { get; set; }
        public string PensFundId { get; set; }
        public string SocInsFundId { get; set; }
        public string SocUnEfundId { get; set; }
        public string SocAddFundId { get; set; }
        public string MinExcPowerId { get; set; }
        public string TaxNotes { get; set; }
        public string TaxOkpo { get; set; }
        public string ActTypeCved { get; set; }
        public string TerritoryId { get; set; }
        public string ExcComRegNum { get; set; }
        public short SysTaxType { get; set; }
        public decimal FixTaxPercent { get; set; }
        public bool TaxPayer { get; set; }
        public string OurNameFull { get; set; }
        public int? ChStart { get; set; }
        public int? ChEnd { get; set; }
        public bool? IsResident { get; set; }
    }
}
