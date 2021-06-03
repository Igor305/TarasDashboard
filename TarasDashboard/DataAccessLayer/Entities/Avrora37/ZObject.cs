using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZObject
    {
        public ZObject()
        {
            ZAccDefObjects = new HashSet<ZAccDefObject>();
            ZRoleObjects = new HashSet<ZRoleObject>();
            ZUserObjects = new HashSet<ZUserObject>();
        }

        public int ObjCode { get; set; }
        public string ObjName { get; set; }
        public string ObjDesc { get; set; }
        public string ObjInfo { get; set; }
        public string ObjType { get; set; }
        public int RevId { get; set; }

        public virtual ICollection<ZAccDefObject> ZAccDefObjects { get; set; }
        public virtual ICollection<ZRoleObject> ZRoleObjects { get; set; }
        public virtual ICollection<ZUserObject> ZUserObjects { get; set; }
    }
}
