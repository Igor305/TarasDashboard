using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VUviewField
    {
        public int ViewId { get; set; }
        public string Caption { get; set; }
        public int Location { get; set; }
        public int SrcPosId { get; set; }
        public bool Visible { get; set; }
        public bool SubTotals { get; set; }
        public string ObjectDef { get; set; }

        public virtual VUview View { get; set; }
    }
}
