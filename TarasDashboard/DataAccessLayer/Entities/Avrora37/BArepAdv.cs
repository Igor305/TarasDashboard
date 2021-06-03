using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BArepAdv
    {
        public long ChId { get; set; }
        public short VcodeId1 { get; set; }
        public short VcodeId2 { get; set; }
        public short VcodeId3 { get; set; }
        public short VcodeId4 { get; set; }
        public short VcodeId5 { get; set; }
        public decimal VkursMc { get; set; }
        public decimal VkursCc { get; set; }
        public short VcurrId { get; set; }
        public decimal VsumAc { get; set; }
        public decimal SumCcNt { get; set; }
        public decimal TaxSum { get; set; }
        public decimal SumCcWt { get; set; }
        public string DocDesc { get; set; }
        public DateTime? BuyDate { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public decimal GvtsumWt { get; set; }
        public decimal GvttaxSum { get; set; }
        public int GvtaccId { get; set; }
    }
}
