using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEoexpC
    {
        public long ChId { get; set; }
        public short CurrId { get; set; }
        public decimal KursCc { get; set; }
        public decimal KursMc { get; set; }
    }
}
