using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZRelation
    {
        public ZRelation()
        {
            VTables = new HashSet<VTable>();
            ZWcopyTs = new HashSet<ZWcopyT>();
        }

        public string RelName { get; set; }
        public int ParentCode { get; set; }
        public string ParentNames { get; set; }
        public string ParentDescs { get; set; }
        public int ChildCode { get; set; }
        public string ChildNames { get; set; }
        public string ChildDescs { get; set; }
        public bool CascUpdate { get; set; }
        public bool CascDelete { get; set; }
        public int RelType { get; set; }

        public virtual ICollection<VTable> VTables { get; set; }
        public virtual ICollection<ZWcopyT> ZWcopyTs { get; set; }
    }
}
