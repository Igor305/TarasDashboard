using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BSrepDv
    {
        public long ChId { get; set; }
        public int VsrcPosId { get; set; }
        public string DocDesc { get; set; }
        public short VcodeId1 { get; set; }
        public short VcodeId2 { get; set; }
        public short VcodeId3 { get; set; }
        public short VcodeId4 { get; set; }
        public short VcodeId5 { get; set; }
        public decimal CostSumCcNt { get; set; }
        public decimal CostTaxSum { get; set; }
        public decimal CostSumCcWt { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal GposTsumWt { get; set; }
        public decimal GposTtaxSum { get; set; }
    }
}
