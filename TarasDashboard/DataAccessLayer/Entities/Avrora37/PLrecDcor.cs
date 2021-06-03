using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLrecDcor
    {
        public long AchId { get; set; }
        public short YearId { get; set; }
        public short MonthId { get; set; }
        public short PayTypeId { get; set; }
        public decimal SumCc { get; set; }
        public bool IsDeduction { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public int DetSrcPosId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
    }
}
