using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZUserDoc
    {
        public short UserCode { get; set; }
        public int DocCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
