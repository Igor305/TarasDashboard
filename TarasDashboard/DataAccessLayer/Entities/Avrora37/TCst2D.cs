using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCst2D
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public string Um { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceAcIn { get; set; }
        public decimal SumAcIn { get; set; }
        public decimal TrtAc { get; set; }
        public decimal CstSumAc { get; set; }
        public decimal CstPriceCc { get; set; }
        public decimal DtyCc { get; set; }
        public decimal Dty2Cc { get; set; }
        public decimal PrcCc { get; set; }
        public decimal ExcCc { get; set; }
        public decimal ImpCc { get; set; }
        public decimal MoreCc { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal SumCcIn { get; set; }
        public decimal CstSumCcIn { get; set; }
        public decimal CstSumCc { get; set; }
        public decimal TrtCc { get; set; }
        public decimal CstDty { get; set; }
        public decimal CstDty2 { get; set; }
        public decimal CstPrc { get; set; }
        public decimal CstExc { get; set; }
        public decimal CstSumCccor { get; set; }
        public int GroupId { get; set; }
        public decimal ExcCostCc { get; set; }
        public decimal CstPriceAc { get; set; }
    }
}
