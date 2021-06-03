using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrItemGr
    {
        public long ChId { get; set; }
        public short ItemGrId { get; set; }
        public string ItemGrName { get; set; }
        public int SrcPosId { get; set; }
    }
}
