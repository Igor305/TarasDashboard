using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCruniInput
    {
        public long ChId { get; set; }
        public int UniInputCode { get; set; }
        public int UniInputAction { get; set; }
        public string UniInputMask { get; set; }
        public string Notes { get; set; }
        public bool UniInput { get; set; }
    }
}
