using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPcostDexp
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public decimal DetSumCcNt { get; set; }
        public decimal DetTaxSum { get; set; }
        public decimal DetSumCcWt { get; set; }
        public string DetNote { get; set; }
        public int DetCompId { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
