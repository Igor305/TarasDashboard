using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCpricesD
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public decimal PriceAc { get; set; }
        public short CpriceType { get; set; }
        public int? SrcPosId { get; set; }
        public string Notes { get; set; }
        public decimal? PriceccWt { get; set; }
    }
}
