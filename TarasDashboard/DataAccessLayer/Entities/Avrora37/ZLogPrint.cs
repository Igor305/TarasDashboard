using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogPrint
    {
        public int LogId { get; set; }
        public DateTime DocDate { get; set; }
        public int DocCode { get; set; }
        public long ChId { get; set; }
        public short UserCode { get; set; }
        public int AppCode { get; set; }
        public string FileName { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
