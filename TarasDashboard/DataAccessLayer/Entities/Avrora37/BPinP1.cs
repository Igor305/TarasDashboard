using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPinP1
    {
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal PriceAc { get; set; }
        public decimal PriceCc { get; set; }
        public decimal PriceMc { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal PriceMcIn { get; set; }
        public decimal CostAc { get; set; }
        public decimal CostCc { get; set; }
        public int CompId { get; set; }
    }
}
