using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZBarMask
    {
        public int SrcPosId { get; set; }
        public byte SimCount { get; set; }
        public string BarExpE { get; set; }
        public string BarExpValue { get; set; }
    }
}
