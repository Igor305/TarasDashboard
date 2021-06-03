using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RWweek
    {
        public long ChId { get; set; }
        public byte WweekTypeId { get; set; }
        public string WweekName { get; set; }
        public string Notes { get; set; }
        public bool IsInt { get; set; }
    }
}
