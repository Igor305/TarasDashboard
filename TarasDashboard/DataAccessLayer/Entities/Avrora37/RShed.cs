using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RShed
    {
        public long ChId { get; set; }
        public short ShedId { get; set; }
        public string ShedName { get; set; }
        public short ShedDaysQty { get; set; }
        public byte WweekTypeId { get; set; }
        public DateTime ShedBdate { get; set; }
        public string Notes { get; set; }
        public bool? ConHolDays { get; set; }
        public bool SlidingShed { get; set; }
        public bool IsIrregShed { get; set; }
    }
}
