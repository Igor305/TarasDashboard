using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenUnknBarCode
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string BarCode { get; set; }
        public decimal Qty { get; set; }
        public string Notes { get; set; }
    }
}
