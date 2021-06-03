using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLstrD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int PostId { get; set; }
        public int EmpCount { get; set; }
        public short DepId { get; set; }
    }
}
