using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RNorm
    {
        public long ChId { get; set; }
        public short YearId { get; set; }
        public string YearName { get; set; }
        public string Notes { get; set; }
    }
}
