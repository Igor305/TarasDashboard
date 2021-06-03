using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItProcessTemp
    {
        public int? Spid { get; set; }
        public string Status { get; set; }
        public string Login { get; set; }
        public string Hostname { get; set; }
        public string Bilkby { get; set; }
        public string Dbname { get; set; }
        public string Command { get; set; }
        public long? Cputime { get; set; }
        public long? Doscio { get; set; }
        public string Lastbatch { get; set; }
        public string ProgramName { get; set; }
        public int? Spid1 { get; set; }
        public string Requestid { get; set; }
    }
}
