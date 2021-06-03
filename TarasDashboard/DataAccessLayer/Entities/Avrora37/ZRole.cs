using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRole
    {
        public ZRole()
        {
            ZAppRoles = new HashSet<ZAppRole>();
            ZDocRoles = new HashSet<ZDocRole>();
            ZRoleDocs = new HashSet<ZRoleDoc>();
            ZRoleObjects = new HashSet<ZRoleObject>();
            ZRoleTables = new HashSet<ZRoleTable>();
            ZRoleUsers = new HashSet<ZRoleUser>();
        }

        public int RoleCode { get; set; }
        public string RoleName { get; set; }
        public string RoleDesc { get; set; }

        public virtual ICollection<ZAppRole> ZAppRoles { get; set; }
        public virtual ICollection<ZDocRole> ZDocRoles { get; set; }
        public virtual ICollection<ZRoleDoc> ZRoleDocs { get; set; }
        public virtual ICollection<ZRoleObject> ZRoleObjects { get; set; }
        public virtual ICollection<ZRoleTable> ZRoleTables { get; set; }
        public virtual ICollection<ZRoleUser> ZRoleUsers { get; set; }
    }
}
