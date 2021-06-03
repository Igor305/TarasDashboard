using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RComp
    {
        public RComp()
        {
            RCompContacts = new HashSet<RCompContact>();
            RCompValues = new HashSet<RCompValue>();
        }

        public long ChId { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public string Address { get; set; }
        public string PostIndex { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Code { get; set; }
        public string TaxRegNo { get; set; }
        public string TaxCode { get; set; }
        public bool TaxPayer { get; set; }
        public string CompDesc { get; set; }
        public string Contact { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Http { get; set; }
        public string Notes { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public bool? UseCodes { get; set; }
        public int Plid { get; set; }
        public bool? UsePl { get; set; }
        public decimal Discount { get; set; }
        public bool? UseDiscount { get; set; }
        public short PayDelay { get; set; }
        public bool? UsePayDelay { get; set; }
        public decimal? MaxCredit { get; set; }
        public bool? CalcMaxCredit { get; set; }
        public int EmpId { get; set; }
        public string Contract1 { get; set; }
        public string Contract2 { get; set; }
        public string Contract3 { get; set; }
        public string License1 { get; set; }
        public string License2 { get; set; }
        public string License3 { get; set; }
        public string Job1 { get; set; }
        public string Job2 { get; set; }
        public string Job3 { get; set; }
        public decimal TranPrc { get; set; }
        public decimal MorePrc { get; set; }
        public byte FirstEventMode { get; set; }
        public string CompShort { get; set; }
        public short CompType { get; set; }
        public short SysTaxType { get; set; }
        public decimal FixTaxPercent { get; set; }
        public bool InStopList { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
        public string PassNo { get; set; }
        public string PassSer { get; set; }
        public DateTime? PassDate { get; set; }
        public string PassDept { get; set; }
        public int CompGrId1 { get; set; }
        public int CompGrId2 { get; set; }
        public int CompGrId3 { get; set; }
        public int CompGrId4 { get; set; }
        public int CompGrId5 { get; set; }
        public string CompNameFull { get; set; }
        public bool Holding { get; set; }
        public bool? IsResident { get; set; }
        public string ReasonRegCode { get; set; }
        public bool CompCustomer { get; set; }

        public virtual ICollection<RCompContact> RCompContacts { get; set; }
        public virtual ICollection<RCompValue> RCompValues { get; set; }
    }
}
