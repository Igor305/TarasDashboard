using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TExc
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int NewStockId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public string IntDocId { get; set; }
        public int CompId { get; set; }
        public decimal Discount { get; set; }
        public short CurrId { get; set; }
        public decimal TsumCcNt { get; set; }
        public decimal TtaxSum { get; set; }
        public decimal TsumCcWt { get; set; }
        public decimal TspendSumCc { get; set; }
        public decimal TrouteSumCc { get; set; }
        public int StateCode { get; set; }
        public int DestStockId { get; set; }
        public DateTime? SendSdate { get; set; }
        public DateTime? SendWdate { get; set; }
        public DateTime? ArrSdate { get; set; }
        public DateTime? ArrWdate { get; set; }
        public int ReasonId { get; set; }
        public int ReasonEmpId { get; set; }
        public int TransfertEmpId { get; set; }
        public bool ChangeStatus { get; set; }
        public string Cubage { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? DelivDate { get; set; }
        public string SendsAccountable { get; set; }
        public string SendwAccountable { get; set; }
        public string ArrsAccountable { get; set; }
        public string ArrwAccountable { get; set; }
        public string Shipmentaccountable { get; set; }
        public DateTime? CheckQa { get; set; }
        public DateTime? PrintDate { get; set; }
    }
}
