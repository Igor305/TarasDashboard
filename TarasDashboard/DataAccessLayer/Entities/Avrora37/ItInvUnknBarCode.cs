using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItInvUnknBarCode
    {
        public int ChId { get; set; }
        public short SrcPosId { get; set; }
        public string BarCode { get; set; }
        public decimal Qty { get; set; }
    }
}
