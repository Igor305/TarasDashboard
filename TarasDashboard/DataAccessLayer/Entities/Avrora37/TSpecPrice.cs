using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSpecPrice
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public int Plid { get; set; }
        public decimal? PriceCc { get; set; }
        public decimal? CostCc { get; set; }
        public decimal? Extra { get; set; }
    }
}
