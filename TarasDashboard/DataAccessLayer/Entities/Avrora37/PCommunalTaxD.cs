using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCommunalTaxD
    {
        public long ChId { get; set; }
        public long AchId { get; set; }
        public int TaxRegionId { get; set; }
        public decimal AvgEmpsQty { get; set; }
        public decimal CommunalSumCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
