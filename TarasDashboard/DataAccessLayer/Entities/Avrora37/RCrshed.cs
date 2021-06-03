using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrshed
    {
        public short Crid { get; set; }
        public int SrcPosId { get; set; }
        public string Shed { get; set; }
        public int CashRegAction { get; set; }
        public bool? UseSched { get; set; }
    }
}
