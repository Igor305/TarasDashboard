using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCurr
    {
        public long ChId { get; set; }
        public short CurrId { get; set; }
        public string CurrName { get; set; }
        public string CurrDesc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
    }
}
