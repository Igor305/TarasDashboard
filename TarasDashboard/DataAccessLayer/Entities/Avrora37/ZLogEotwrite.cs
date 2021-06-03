using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogEotwrite
    {
        public int LogId { get; set; }
        public int LogPosId { get; set; }
        public DateTime? LogDate { get; set; }
        public string Name { get; set; }
        public int? Spid { get; set; }
        public string Host { get; set; }
        public int? ChId { get; set; }
        public int? Time { get; set; }
    }
}
