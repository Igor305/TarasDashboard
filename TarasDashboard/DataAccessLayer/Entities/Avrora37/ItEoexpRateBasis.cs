using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEoexpRateBasis
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public decimal BaseRate { get; set; }
        public decimal SaleSumCc { get; set; }
        public decimal RemRecSumCc { get; set; }
        public decimal RemAsumCc { get; set; }
        public decimal NormRemAsumCc { get; set; }
    }
}
