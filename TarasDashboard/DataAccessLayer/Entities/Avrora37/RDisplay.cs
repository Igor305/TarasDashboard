using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDisplay
    {
        public int Wpid { get; set; }
        public int DisplayId { get; set; }
        public string DisplayName { get; set; }
        public byte DisplayModel { get; set; }
        public byte Port { get; set; }
        public short Baudrate { get; set; }
    }
}
