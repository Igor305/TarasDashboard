using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RTaxRegionRate
    {
        public int TaxRegionId { get; set; }
        public DateTime SrcDate { get; set; }
        public decimal CommunalTaxRate { get; set; }
    }
}
