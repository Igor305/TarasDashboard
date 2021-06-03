using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMp1
    {
        public int Plid { get; set; }
        public int ProdId { get; set; }
        public short CurrId { get; set; }
        public string CurrName { get; set; }
        public decimal PriceAc { get; set; }
        public decimal? PriceCc { get; set; }
        public decimal? PriceMc { get; set; }
    }
}
