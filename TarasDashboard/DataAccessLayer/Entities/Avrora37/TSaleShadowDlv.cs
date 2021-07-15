using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSaleShadowDlv
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int LevyId { get; set; }
        public decimal LevySum { get; set; }
    }
}
