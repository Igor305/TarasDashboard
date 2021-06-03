using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAppRole
    {
        public int AppCode { get; set; }
        public int RoleCode { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
        public virtual ZRole RoleCodeNavigation { get; set; }
    }
}
