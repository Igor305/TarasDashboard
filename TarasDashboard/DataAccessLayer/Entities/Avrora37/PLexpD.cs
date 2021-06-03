using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLexpD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public decimal LarrSumCc { get; set; }
        public decimal LrecSumCc { get; set; }
        public decimal LexpSumCc { get; set; }
        public decimal LdepSumCc { get; set; }
        public short SubId { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public short DepId { get; set; }
    }
}
