using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDiscChargeD
    {
        public int DiscCode { get; set; }
        public int SrcPosId { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
        public string LfilterExp { get; set; }
        public string EfilterExp { get; set; }
        public int BonusType { get; set; }
        public bool ChargeOnlyIfDisc { get; set; }
        public bool ChargeBeforeDisc { get; set; }
        public bool ChargeAfterDisc { get; set; }
        public bool ChargeAfterChequeDisc { get; set; }
        public string LchargeBonusExp { get; set; }
        public string EchargeBonusExp { get; set; }

        public virtual RDisc DiscCodeNavigation { get; set; }
    }
}
