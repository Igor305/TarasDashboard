using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSrecD
    {
        public long AchId { get; set; }
        public int SubSrcPosId { get; set; }
        public int SubProdId { get; set; }
        public int SubPpid { get; set; }
        public string SubUm { get; set; }
        public decimal SubQty { get; set; }
        public decimal SubPriceCcNt { get; set; }
        public decimal SubSumCcNt { get; set; }
        public decimal SubTax { get; set; }
        public decimal SubTaxSum { get; set; }
        public decimal SubPriceCcWt { get; set; }
        public decimal SubSumCcWt { get; set; }
        public decimal SubNewPriceCcNt { get; set; }
        public decimal SubNewSumCcNt { get; set; }
        public decimal SubNewTax { get; set; }
        public decimal SubNewTaxSum { get; set; }
        public decimal SubNewPriceCcWt { get; set; }
        public decimal SubNewSumCcWt { get; set; }
        public int SubSecId { get; set; }
        public string SubBarCode { get; set; }
    }
}
