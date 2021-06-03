using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PSubStrucD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public short SubId { get; set; }
        public short ParentSubId { get; set; }
        public string Notes { get; set; }
    }
}
