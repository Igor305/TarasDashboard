using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcWt { get; set; }
        public decimal SumCcWt { get; set; }
        public decimal CostSum { get; set; }
        public decimal CostCc { get; set; }
        public decimal? Extra { get; set; }
        public decimal PriceCc { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
        public int PgrId3 { get; set; }
        public string Notes { get; set; }
        public string Note2 { get; set; }
        public int WempId { get; set; }
        public int RecCatId { get; set; }
        public int Status { get; set; }
        public DateTime? FinishDate { get; set; }
        public short? Mplicity { get; set; }
        public decimal PriceAcNt { get; set; }
        public decimal TaxAc { get; set; }
        public decimal PriceAcWt { get; set; }
        public byte? QuantStock { get; set; }
        public string CstProdCode { get; set; }
        public decimal ExPlanQty { get; set; }
        public decimal ReGradingQty { get; set; }
        public decimal LastVenQty { get; set; }
        public decimal? FactQtyWms { get; set; }
        public short? CounId { get; set; }
    }
}
