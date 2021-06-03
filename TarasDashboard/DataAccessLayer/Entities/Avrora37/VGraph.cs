using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VGraph
    {
        public int RepId { get; set; }
        public int GraphId { get; set; }
        public string GraphName { get; set; }
        public string GraphDef { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
