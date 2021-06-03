using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RShedM
    {
        public short ShedId { get; set; }
        public short DayPosId { get; set; }
        public byte ShiftId { get; set; }
        public DateTime Btime { get; set; }
        public DateTime Etime { get; set; }
        public DateTime ShiftLength { get; set; }
        public string ShiftDesc { get; set; }
        public DateTime BintTime { get; set; }
        public DateTime EintTime { get; set; }
        public DateTime IntLength { get; set; }
    }
}
