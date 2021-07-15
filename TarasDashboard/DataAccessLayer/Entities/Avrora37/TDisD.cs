using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDisD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal RemQty { get; set; }
        public decimal AccQty { get; set; }
        public string BarCode { get; set; }
        public long AchId { get; set; }
        public int SecId { get; set; }
        public int PgrId3 { get; set; }
        public decimal StockQty { get; set; }
        public decimal TransQty { get; set; }
        public string Notes { get; set; }
        public string Note2 { get; set; }
        public decimal Ioqty { get; set; }
        public decimal TremQty { get; set; }
        public decimal TsaleQty { get; set; }
        public decimal TrecQty { get; set; }
        public decimal TeppQty { get; set; }
        public decimal Tnsqty { get; set; }
        public decimal ProdRate { get; set; }
        public decimal ToptQty { get; set; }
        public int WempId { get; set; }
        public int RecCatId { get; set; }
        public byte CalcType { get; set; }
        public bool Recalc { get; set; }
        public decimal? Capacity { get; set; }
        public decimal? Weight { get; set; }
        public decimal? DistributionQty { get; set; }
        public int? ColCatId { get; set; }
        public short? Mplicity { get; set; }
        public short? Datediff { get; set; }
        public byte? QuantStock { get; set; }
        public decimal? QtyStock1300 { get; set; }
        public decimal? QtyStock301600 { get; set; }
        public decimal? StockQtyDis { get; set; }
        public bool? FirstPriceProduct { get; set; }
        public short? TypeTreatment { get; set; }
    }
}
