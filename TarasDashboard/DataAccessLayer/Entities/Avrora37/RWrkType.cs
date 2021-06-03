using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RWrkType
    {
        public long ChId { get; set; }
        public int WrkId { get; set; }
        public string WrkName { get; set; }
        public string Notes { get; set; }
        public decimal PriceCc { get; set; }
        public decimal? Value1 { get; set; }
        public decimal? Value2 { get; set; }
        public decimal? Value3 { get; set; }
    }
}
