using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPcostDdexpProd
    {
        public long AchId { get; set; }
        public int SrcPosId { get; set; }
        public int DetProdId { get; set; }
        public int DetPpid { get; set; }
        public string DetUm { get; set; }
        public decimal DetQty { get; set; }
        public decimal DetPriceCcNt { get; set; }
        public decimal DetSumCcNt { get; set; }
        public decimal DetTax { get; set; }
        public decimal DetTaxSum { get; set; }
        public decimal DetPriceCcWt { get; set; }
        public decimal DetSumCcWt { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
