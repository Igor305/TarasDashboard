using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrsrv
    {
        public long ChId { get; set; }
        public byte SrvId { get; set; }
        public string SrvName { get; set; }
        public string Notes { get; set; }
        public int OurId { get; set; }
        public string Host { get; set; }
        public int? NetPort { get; set; }
    }
}
