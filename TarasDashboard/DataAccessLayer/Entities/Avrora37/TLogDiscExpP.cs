using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TLogDiscExpP
    {
        public int LogId { get; set; }
        public int DbiId { get; set; }
        public long ChId { get; set; }
        public int DocCode { get; set; }
        public int? SrcPosId { get; set; }
        public int DiscCode { get; set; }
        public decimal? SumBonus { get; set; }
        public DateTime LogDate { get; set; }
        public long DcardChId { get; set; }

        public virtual RDcard DcardCh { get; set; }
        public virtual RDisc DiscCodeNavigation { get; set; }
    }
}
