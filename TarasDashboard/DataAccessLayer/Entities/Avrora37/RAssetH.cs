using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RAssetH
    {
        public int AssId { get; set; }
        public DateTime Bdate { get; set; }
        public int AgrId { get; set; }
        public int AcatId { get; set; }
        public decimal? Age { get; set; }
        public decimal PriceCcNt { get; set; }
        public decimal SupPriceCcNt { get; set; }
        public decimal WerSumCcNt { get; set; }
        public decimal DepSumCcNt { get; set; }
        public decimal RepSumCcNt { get; set; }
        public byte ChargeType { get; set; }
        public byte ChargeTypeDep { get; set; }
        public decimal LiqPriceCcNt { get; set; }
        public decimal GenQty { get; set; }
        public int EmpId { get; set; }
        public int GaccId { get; set; }
        public bool IsProdAss { get; set; }
        public short DepId { get; set; }
        public string Notes { get; set; }
    }
}
