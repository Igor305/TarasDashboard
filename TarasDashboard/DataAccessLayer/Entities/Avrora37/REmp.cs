using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmp
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string UaempName { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpParName { get; set; }
        public string UaempLastName { get; set; }
        public string UaempFirstName { get; set; }
        public string UaempParName { get; set; }
        public string EmpInitials { get; set; }
        public string UaempInitials { get; set; }
        public string TaxCode { get; set; }
        public byte EmpSex { get; set; }
        public DateTime? BirthDay { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public short? Education { get; set; }
        public short? FamilyStatus { get; set; }
        public string BirthPlace { get; set; }
        public string Phone { get; set; }
        public string InPhone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }
        public decimal Percent3 { get; set; }
        public string Notes { get; set; }
        public short? MilStatus { get; set; }
        public short? MilFitness { get; set; }
        public string MilRank { get; set; }
        public string MilSpecialCalc { get; set; }
        public string MilProfes { get; set; }
        public string MilCalcGrp { get; set; }
        public string MilCalcCat { get; set; }
        public string MilStaff { get; set; }
        public string MilRegOffice { get; set; }
        public string MilNum { get; set; }
        public string PassNo { get; set; }
        public string PassSer { get; set; }
        public DateTime? PassDate { get; set; }
        public string PassDept { get; set; }
        public string DisNum { get; set; }
        public string PensNum { get; set; }
        public string WorkBookNo { get; set; }
        public string WorkBookSer { get; set; }
        public string PerFileNo { get; set; }
        public bool InStopList { get; set; }
        public string BarCode { get; set; }
        public int ShiftPostId { get; set; }
        public bool? IsCitizen { get; set; }
        public int MaxEmpCredit { get; set; }
        public int StockId { get; set; }
        public int PostId { get; set; }
        public int WteamId { get; set; }
        public string CertInsurSer { get; set; }
        public string CertInsurNum { get; set; }
        public string EmpBarCode { get; set; }
    }
}
