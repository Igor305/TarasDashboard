using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdBg
    {
        public long ChId { get; set; }
        public short PbgrId { get; set; }
        public string PbgrName { get; set; }
        public string Notes { get; set; }
        public bool Tare { get; set; }
    }
}
