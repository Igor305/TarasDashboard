using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdMpch
    {
        public long ChId { get; set; }
        public DateTime ChDate { get; set; }
        public DateTime ChTime { get; set; }
        public int ProdId { get; set; }
        public int Plid { get; set; }
        public short OldCurrId { get; set; }
        public decimal OldPriceMc { get; set; }
        public short CurrId { get; set; }
        public decimal PriceMc { get; set; }
        public short UserId { get; set; }
        public long DocChId { get; set; }
        public int DocCode { get; set; }
        public int CompId { get; set; }
    }
}
