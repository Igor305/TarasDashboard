using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvReportSalesFrequencyAnalysis
    {
        public string DcardId { get; set; }
        public int Dcqty { get; set; }
        public int DctypeCode { get; set; }
        public string DctypeName { get; set; }
        public decimal SumBonus { get; set; }
        public decimal Discount { get; set; }
        public string PersonName { get; set; }
        public bool IsSalary { get; set; }
        public string FactRegion { get; set; }
        public string FactDistrict { get; set; }
        public string FactCity { get; set; }
        public string FactStreet { get; set; }
        public string FactHouse { get; set; }
        public string FactAptNo { get; set; }
        public string FactPostIndex { get; set; }
        public string Phone { get; set; }
        public string PhoneHome { get; set; }
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Notes { get; set; }
        public string Sex { get; set; }
        public string FamilyStatus { get; set; }
        public int? TchequeQty { get; set; }
        public decimal TprodQty { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal? AvgCheque { get; set; }
        public DateTime? MaxDocDate { get; set; }
        public DateTime? MinDocDate { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string Address { get; set; }
        public short Crid { get; set; }
        public string Crname { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal ChequeSum { get; set; }
        public decimal ChequeProdQty { get; set; }
        public int Status { get; set; }
        public int? Age { get; set; }
    }
}
