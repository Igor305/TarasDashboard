using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogStockAttribute
    {
        public int LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int DocCode { get; set; }
        public int Stockid { get; set; }
        public int OldStateCode { get; set; }
        public int NewStateCode { get; set; }
        public short UserCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
