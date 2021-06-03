using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VView
    {
        public VView()
        {
            VViewFields = new HashSet<VViewField>();
        }

        public int RepId { get; set; }
        public int ViewId { get; set; }
        public string ViewName { get; set; }
        public bool GrandCols { get; set; }
        public bool GrandRows { get; set; }
        public bool FixCols { get; set; }
        public bool? FixRows { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
        public virtual ICollection<VViewField> VViewFields { get; set; }
    }
}
