using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRoleTable
    {
        public int RoleCode { get; set; }
        public int TableCode { get; set; }
        public byte AccRead { get; set; }
        public byte AccInsert { get; set; }
        public byte AccUpdate { get; set; }
        public byte AccDelete { get; set; }

        public virtual ZRole RoleCodeNavigation { get; set; }
        public virtual ZTable TableCodeNavigation { get; set; }
    }
}
