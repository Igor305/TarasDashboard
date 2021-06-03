using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TPinPch
    {
        public long ChId { get; set; }
        public DateTime ChDate { get; set; }
        public DateTime ChTime { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public short OldCurrId { get; set; }
        public decimal OldPriceMcIn { get; set; }
        public decimal OldPriceMc { get; set; }
        public short CurrId { get; set; }
        public decimal PriceMcIn { get; set; }
        public decimal PriceMc { get; set; }
        public short UserId { get; set; }
        public decimal OldPriceCcIn { get; set; }
        public decimal PriceCcIn { get; set; }
        public decimal OldPriceAcIn { get; set; }
        public decimal PriceAcIn { get; set; }
    }
}
