using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RMod
    {
        public long ChId { get; set; }
        public int ModCode { get; set; }
        public string ModName { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Notes { get; set; }
        public bool Required { get; set; }
        public bool IsProd { get; set; }
        public int ProdId { get; set; }
        public int Color { get; set; }
        public byte[] Picture { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
    }
}
