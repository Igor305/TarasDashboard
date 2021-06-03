using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VUgraph
    {
        public int RepId { get; set; }
        public int GraphId { get; set; }
        public string GraphName { get; set; }
        public string GraphDef { get; set; }
        public short UserId { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
        public virtual RUser User { get; set; }
    }
}
