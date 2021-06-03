using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RShedMd
    {
        public short ShedId { get; set; }
        public short DayPosId { get; set; }
        public byte ShifsQty { get; set; }
        public decimal HoursInDay { get; set; }
        public string DayDesc { get; set; }
    }
}
