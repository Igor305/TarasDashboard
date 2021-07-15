using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRec1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short CurrId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int CompId { get; set; }
        public decimal KursCc { get; set; }
        public decimal KursMc { get; set; }
        public decimal TsumAc { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public int StateCode { get; set; }
        public short PayDelay { get; set; }
        public DateTime? PayDocDate { get; set; }
        public string SrcDocId { get; set; }
        public DateTime? SrcDocDate { get; set; }
        public string ChildDocId { get; set; }
        public string Notes { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime? RecPlanEdate { get; set; }
        public DateTime? RecFactEdate { get; set; }
        public int CompGrId2 { get; set; }
        public long RlogDocId { get; set; }
        public DateTime? ShipDate { get; set; }
        public decimal Tqty { get; set; }
        public string ContainerNumber { get; set; }
        public decimal? ProdCount { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? CheckQualityDate { get; set; }
        public string CustomerName { get; set; }
        public int? DocIdwms { get; set; }
        public DateTime? DocDateWms { get; set; }
    }
}
