using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSpecD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public string OutUm { get; set; }
        public decimal Qty { get; set; }
        public decimal Percent1 { get; set; }
        public decimal Percent2 { get; set; }
        public bool UseSubItems { get; set; }
        public string OperDesc { get; set; }
    }
}
