using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvControlOfOrder
    {
        public long ChId { get; set; }
        public int? ProdId { get; set; }
        public string Um { get; set; }
        public string ProdName { get; set; }
        public int? PgrId3 { get; set; }
        public string PgrName3 { get; set; }
        public decimal? RecQty { get; set; }
        public decimal? RecSum { get; set; }
        public decimal? EoexpQty { get; set; }
        public decimal? EoexpSum { get; set; }
        public decimal? EppQty1 { get; set; }
        public decimal? EppSum1 { get; set; }
        public decimal? EppQty2 { get; set; }
        public decimal? EppSum2 { get; set; }
        public decimal? EppQty3 { get; set; }
        public decimal? EppSum3 { get; set; }
        public decimal? EppQty4 { get; set; }
        public decimal? EppSum4 { get; set; }
        public decimal? EppQty5 { get; set; }
        public decimal? EppSum5 { get; set; }
        public bool? IsDiffArt { get; set; }
        public bool? IsDiffPriceWt { get; set; }
        public bool? IsDiffQty { get; set; }
        public bool? OutRec { get; set; }
    }
}
