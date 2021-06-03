using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RTaxRegion
    {
        public long ChId { get; set; }
        public int TaxRegionId { get; set; }
        public string TaxRegionName { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        public string Notes { get; set; }
    }
}
