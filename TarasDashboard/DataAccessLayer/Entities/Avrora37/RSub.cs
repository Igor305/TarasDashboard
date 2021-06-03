using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RSub
    {
        public long ChId { get; set; }
        public short SubId { get; set; }
        public string SubName { get; set; }
        public DateTime? FormDate { get; set; }
        public DateTime? DisbDate { get; set; }
        public short ShedId { get; set; }
        public string Notes { get; set; }
        public int TaxRegionId { get; set; }
    }
}
