using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCommunalTaxDd
    {
        public long AchId { get; set; }
        public int CostGaccId { get; set; }
        public decimal GaccCommunalSumCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
