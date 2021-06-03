using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPerson
    {
        public long ChId { get; set; }
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string BarCode { get; set; }
        public DateTime? Birthday { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Preferences { get; set; }
        public int? ReferalPersonId { get; set; }
        public int State { get; set; }
        public byte[] Picture { get; set; }
        public byte Sex { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string FactRegion { get; set; }
        public string FactDistrict { get; set; }
        public string FactCity { get; set; }
        public string FactStreet { get; set; }
        public string FactHouse { get; set; }
        public string FactBlock { get; set; }
        public string FactAptNo { get; set; }
        public string Notes { get; set; }
        public string FactPostIndex { get; set; }
        public bool AddOdnokl { get; set; }
        public bool AddVk { get; set; }
        public bool AddFacebook { get; set; }
        public bool NotReceiveInfo { get; set; }
        public bool NotReceiveEmail { get; set; }
        public bool NotReceiveSms { get; set; }
        public short FamilyStatus { get; set; }
        public DateTime? FillingDate { get; set; }
        public bool IsSalary { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int? Empid { get; set; }
    }
}
