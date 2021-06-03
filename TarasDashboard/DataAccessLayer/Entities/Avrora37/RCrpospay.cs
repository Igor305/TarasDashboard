using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrpospay
    {
        public int PospayId { get; set; }
        public bool IsDefault { get; set; }
        public int Wpid { get; set; }
    }
}
