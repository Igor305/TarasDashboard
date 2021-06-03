using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCstD
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
        public decimal PrcCc { get; set; }
        public decimal ExcCc { get; set; }
        public decimal ImpCc { get; set; }
        public decimal MoreCc { get; set; }
        public decimal Tax { get; set; }
        public decimal TaxSum { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal SumCcIn { get; set; }
        public string BarCode { get; set; }
        public int SecId { get; set; }
    }
}
