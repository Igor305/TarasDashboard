using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VRepGr
    {
        public VRepGr()
        {
            VReps = new HashSet<VRep>();
        }

        public short RepGrId { get; set; }
        public string RepGrName { get; set; }

        public virtual ICollection<VRep> VReps { get; set; }
    }
}
