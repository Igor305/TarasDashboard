using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSaleTempM
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int ModCode { get; set; }
        public int ModQty { get; set; }
        public bool IsProd { get; set; }
        public int? SaleSrcPosId { get; set; }
    }
}
