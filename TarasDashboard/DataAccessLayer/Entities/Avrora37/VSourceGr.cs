using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VSourceGr
    {
        public int RepId { get; set; }
        public string SourceGrName { get; set; }
        public int SrcPosId { get; set; }
        public short SourceGrType { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
