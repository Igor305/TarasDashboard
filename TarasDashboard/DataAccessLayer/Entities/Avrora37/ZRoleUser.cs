using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRoleUser
    {
        public int RoleCode { get; set; }
        public short UserCode { get; set; }

        public virtual ZRole RoleCodeNavigation { get; set; }
        public virtual RUser UserCodeNavigation { get; set; }
    }
}
