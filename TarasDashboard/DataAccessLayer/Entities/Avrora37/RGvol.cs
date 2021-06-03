using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RGvol
    {
        public long ChId { get; set; }
        public int GvolId { get; set; }
        public string GvolName { get; set; }
        public string Notes { get; set; }
    }
}
