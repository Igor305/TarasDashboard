using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class POpwrkD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public string SumExpE { get; set; }
        public string SumExpR { get; set; }
        public short DepId { get; set; }
    }
}
