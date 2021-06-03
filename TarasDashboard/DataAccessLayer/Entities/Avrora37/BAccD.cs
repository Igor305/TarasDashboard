using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BAccD
    {
        public long ChId { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
    }
}
