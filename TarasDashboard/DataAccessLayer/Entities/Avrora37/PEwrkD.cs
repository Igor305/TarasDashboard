using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEwrkD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public int WrkId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCc { get; set; }
        public decimal SumCc { get; set; }
    }
}
