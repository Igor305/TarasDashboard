using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLrecDd
    {
        public long AchId { get; set; }
        public int DetSrcPosId { get; set; }
        public short SubId { get; set; }
        public short PayTypeId { get; set; }
        public decimal SumCc { get; set; }
        public bool IsDeduction { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public short DepId { get; set; }
        public DateTime SrcDate { get; set; }
        public decimal UniSocChargeRate { get; set; }
        public decimal UniSocDedRate { get; set; }
        public decimal UniSocChargeСс { get; set; }
        public decimal UniSocDedСс { get; set; }
        public decimal BincomeTaxCc { get; set; }
    }
}
