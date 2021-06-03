using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogUpdate
    {
        public int LogId { get; set; }
        public DateTime DocTime { get; set; }
        public int TableCode { get; set; }
        public long ChId { get; set; }
        public string Pkvalue { get; set; }
        public short UserCode { get; set; }
    }
}
