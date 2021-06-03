using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RGoper
    {
        public long ChId { get; set; }
        public int GoperId { get; set; }
        public string GoperName { get; set; }
        public string Notes { get; set; }
        public bool? WasChanged { get; set; }
        public short GoperCid { get; set; }
        public int RevId { get; set; }
        public string RevName { get; set; }
    }
}
