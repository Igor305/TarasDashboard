using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocDc
    {
        public int DocCode { get; set; }
        public long ChId { get; set; }
        public long DcardChId { get; set; }

        public virtual RDcard DcardCh { get; set; }
        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
