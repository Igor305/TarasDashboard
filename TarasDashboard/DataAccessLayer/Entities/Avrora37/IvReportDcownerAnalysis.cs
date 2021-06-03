using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvReportDcownerAnalysis
    {
        public string DcardId { get; set; }
        public int Dcqty { get; set; }
        public int DctypeCode { get; set; }
        public string DctypeName { get; set; }
        public string ClientName { get; set; }
        public string FactRegion { get; set; }
        public string FactDistrict { get; set; }
        public string FactCity { get; set; }
        public string FactStreet { get; set; }
        public string FactHouse { get; set; }
        public string FactAptNo { get; set; }
        public string FactPostIndex { get; set; }
        public string PhoneMob { get; set; }
        public string PhoneHome { get; set; }
        public string Email { get; set; }
        public int FilledEmail { get; set; }
        public DateTime? FillingDate { get; set; }
        public string Surname { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public byte? Sex { get; set; }
        public string BirtDay { get; set; }
        public string FamilyStatus { get; set; }
        public bool IsSalary { get; set; }
        public decimal Discount { get; set; }
        public decimal SumBonus { get; set; }
        public decimal? SumCc { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? OwnerAge { get; set; }
        public bool? AddOdnokl { get; set; }
        public bool? AddVk { get; set; }
        public bool? AddFacebook { get; set; }
        public bool? NotReceiveInfo { get; set; }
        public bool? NotReceiveEmail { get; set; }
        public bool? NotReceiveSms { get; set; }
        public decimal AvgCheque { get; set; }
        public int? KinQty { get; set; }
        public string KinName { get; set; }
        public DateTime? KinBirthDay { get; set; }
        public int? KinAge { get; set; }
        public int Dfield { get; set; }
        public int StockId { get; set; }
    }
}
