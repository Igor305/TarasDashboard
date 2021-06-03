using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRoleDoc
    {
        public int RoleCode { get; set; }
        public int DocCode { get; set; }

        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual ZRole RoleCodeNavigation { get; set; }
    }
}
