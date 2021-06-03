using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAccDefDoc
    {
        public int AccDefCode { get; set; }
        public int DocCode { get; set; }

        public virtual ZAccDef AccDefCodeNavigation { get; set; }
        public virtual ZDoc DocCodeNavigation { get; set; }
    }
}
