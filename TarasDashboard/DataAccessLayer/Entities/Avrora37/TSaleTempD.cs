using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSaleTempD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal? Qty { get; set; }
        public decimal? RealQty { get; set; }
        public decimal? PriceCcWt { get; set; }
        public decimal? SumCcWt { get; set; }
        public decimal? PurPriceCcWt { get; set; }
        public decimal? PurSumCcWt { get; set; }
        public string BarCode { get; set; }
        public string RealBarCode { get; set; }
        public int Plid { get; set; }
        public int? UseToBarQty { get; set; }
        public int PosStatus { get; set; }
        public DateTime? ServingTime { get; set; }
        public int CsrcPosId { get; set; }
        public int ServingId { get; set; }
        public int CreasonId { get; set; }
        public DateTime? PrintTime { get; set; }
        public bool? CanEditQty { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
        public decimal NewQty { get; set; }
        public int TaxTypeId { get; set; }
        public bool AllowZeroPrice { get; set; }
    }
}
