using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogState
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int StateRuleCode { get; set; }
        public int DocCode { get; set; }
        public long ChId { get; set; }
        public int OldStateCode { get; set; }
        public int NewStateCode { get; set; }
        public short UserCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
