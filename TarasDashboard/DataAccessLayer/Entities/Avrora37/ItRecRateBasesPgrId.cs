using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRecRateBasesPgrId
    {
        public long ChId { get; set; }
        public int Stockid { get; set; }
        public decimal Baserate { get; set; }
        public decimal Salesumcc { get; set; }
        public decimal RemRecSumCc { get; set; }
        public decimal RemAsumCc { get; set; }
        public decimal NormRemAsumcc { get; set; }
        public int Pgrid { get; set; }
    }
}
