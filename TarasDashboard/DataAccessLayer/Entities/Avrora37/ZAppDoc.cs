using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAppDoc
    {
        public int AppCode { get; set; }
        public int DocCode { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
