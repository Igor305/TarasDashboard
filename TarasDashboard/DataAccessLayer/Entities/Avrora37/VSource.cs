using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VSource
    {
        public VSource()
        {
            VJoins = new HashSet<VJoin>();
        }

        public int RepId { get; set; }
        public short SourceId { get; set; }
        public string SourceName { get; set; }
        public int DocCode { get; set; }
        public int SourceType { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
        public virtual ICollection<VJoin> VJoins { get; set; }
    }
}
