using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrRegion
    {
        public long ChId { get; set; }
        public int RegionId { get; set; }
        public string Region { get; set; }
        public string Notes { get; set; }
    }
}
