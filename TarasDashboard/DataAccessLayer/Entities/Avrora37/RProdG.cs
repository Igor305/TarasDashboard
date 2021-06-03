using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdG
    {
        public long ChId { get; set; }
        public int PgrId { get; set; }
        public string PgrName { get; set; }
        public string Notes { get; set; }
        public short CodeId4 { get; set; }
    }
}
