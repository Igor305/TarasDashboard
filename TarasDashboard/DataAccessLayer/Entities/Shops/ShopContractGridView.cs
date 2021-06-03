using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ShopContractGridView
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ContractNumber { get; set; }
        public DateTime? ConclusionDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Prolongation { get; set; }
        public int ContractExistenceStatus { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public decimal? PaymentF1 { get; set; }
        public decimal? PaymentF2 { get; set; }
        public decimal? ContractSum { get; set; }
        public decimal? TotalSum { get; set; }
        public decimal? SecurityPayment { get; set; }
        public decimal? AdditionalAgreementF2 { get; set; }
        public bool? FireSurveillanceContract { get; set; }
        public string Comments { get; set; }
        public byte[] PrivateEntrepreneurByContractId { get; set; }
        public int ContractTypeId { get; set; }
        public string ContractTypeName { get; set; }
        public byte[] ContractorId { get; set; }
        public byte[] ManagerId { get; set; }
        public int ShopId { get; set; }
        public string PrivateEntrepreneurByContract { get; set; }
        public string ManagerName { get; set; }
        public string ContractorName { get; set; }
        public string CodeEgrpou { get; set; }
        public string LegalAddress { get; set; }
    }
}
