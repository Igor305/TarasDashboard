using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocRole
    {
        public int DocCode { get; set; }
        public int RoleCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual ZRole RoleCodeNavigation { get; set; }
    }
}
