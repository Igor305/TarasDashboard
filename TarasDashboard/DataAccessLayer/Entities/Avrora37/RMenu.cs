using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RMenu
    {
        public long ChId { get; set; }
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string Notes { get; set; }
        public byte[] Picture { get; set; }
        public int? BgColor { get; set; }
    }
}
