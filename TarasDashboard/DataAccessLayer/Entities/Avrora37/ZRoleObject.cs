using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRoleObject
    {
        public int RoleCode { get; set; }
        public int ObjCode { get; set; }
        public byte AccRun { get; set; }

        public virtual ZObject ObjCodeNavigation { get; set; }
        public virtual ZRole RoleCodeNavigation { get; set; }
    }
}
