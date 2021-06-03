using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrWteam
    {
        public long ChId { get; set; }
        public int WteamId { get; set; }
        public string WteamName { get; set; }
        public string Notes { get; set; }
    }
}
