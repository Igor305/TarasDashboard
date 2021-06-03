using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvReportSalesAnalysis
    {
        public int Dcqty { get; set; }
        public string DcardId { get; set; }
        public int DctypeCode { get; set; }
        public string DctypeName { get; set; }
        public string ClientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Возраст { get; set; }
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
        public bool IsSalary { get; set; }
        public string Sex { get; set; }
        public string FamilyStatus { get; set; }
        public bool NotReceiveInfo { get; set; }
        public bool NotReceiveEmail { get; set; }
        public bool NotReceiveSms { get; set; }
        public int Status { get; set; }
        public string BirthDay { get; set; }
        public int? ProdQtyDist { get; set; }
        public decimal? ProdQtyAll { get; set; }
        public decimal? ProdQty5 { get; set; }
        public decimal? ProdQty10 { get; set; }
        public decimal? ProdQty15 { get; set; }
        public decimal? ProdQty20 { get; set; }
        public decimal? ProdQty25 { get; set; }
        public decimal? ProdQty30 { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public string Address { get; set; }
        public short Crid { get; set; }
        public string Crname { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime? DocCreateTime { get; set; }
        public decimal ChequeSum { get; set; }
        public int? PayFormCode { get; set; }
        public string PayFormName { get; set; }
        public decimal? DiscSumBonus { get; set; }
        public decimal? ChequeProdQty { get; set; }
        public int PcatId { get; set; }
        public string PcatName { get; set; }
        public int PgrId { get; set; }
        public string PgrName { get; set; }
        public int PgrId1 { get; set; }
        public string PgrName1 { get; set; }
        public int PgrId2 { get; set; }
        public string PgrName2 { get; set; }
        public int PgrId3 { get; set; }
        public string PgrName3 { get; set; }
        public string Article1 { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public decimal Qty { get; set; }
        public decimal PurPriceCcWt { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal? ChequePosDiscount { get; set; }
        public decimal? PurSumCcWt { get; set; }
        public decimal? SumCcWt { get; set; }
        public DateTime? FillingDate { get; set; }
        public decimal? ПрибыльНаценкаНаТовар { get; set; }
        public decimal? ExpSumBonus { get; set; }
        public decimal? ОстатокБонусовНаДк { get; set; }
    }
}
