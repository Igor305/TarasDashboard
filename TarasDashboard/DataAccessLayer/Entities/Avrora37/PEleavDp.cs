using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEleavDp
    {
        public long AchId { get; set; }
        public DateTime SrcDate { get; set; }
        public short LeavDays { get; set; }
        public decimal PleavSumCc { get; set; }
    }
}
