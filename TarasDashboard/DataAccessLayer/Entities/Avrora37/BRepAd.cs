using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BRepAd
    {
        public long ChId { get; set; }
        public int AssId { get; set; }
        public string Um { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public string DocDesc { get; set; }
        public DateTime? BuyDate { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
