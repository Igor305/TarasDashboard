using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAgentScript
    {
        public long ChId { get; set; }
        public string Shed { get; set; }
        public string ScriptName { get; set; }
        public string ServiceName { get; set; }
        public bool UseSched { get; set; }
        public string ExecStr { get; set; }
        public DateTime? LastRun { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
    }
}
