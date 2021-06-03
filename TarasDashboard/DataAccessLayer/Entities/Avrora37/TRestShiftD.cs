using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRestShiftD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public int ShiftPostId { get; set; }

        public virtual TRestShift Ch { get; set; }
    }
}
