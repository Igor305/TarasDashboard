using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpInLeav
    {
        public long ChId { get; set; }
        public int LeavType { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public short LeavDays { get; set; }
        public DateTime AgeBdate { get; set; }
        public DateTime AgeEdate { get; set; }
    }
}
