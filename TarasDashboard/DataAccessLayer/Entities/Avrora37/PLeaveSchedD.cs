using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLeaveSchedD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int LeavType { get; set; }
        public DateTime AgeBdate { get; set; }
        public short LeavDays { get; set; }
        public string Notes { get; set; }
    }
}
