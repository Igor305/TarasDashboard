using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSprecM
    {
        public long ChId { get; set; }
        public short CostCodeId1 { get; set; }
        public short CostCodeId2 { get; set; }
        public short CostCodeId3 { get; set; }
        public short CostCodeId4 { get; set; }
        public short CostCodeId5 { get; set; }
        public decimal CostSumCc { get; set; }
    }
}
