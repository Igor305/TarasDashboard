using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRemDStaticH
    {
        public int ChId { get; set; }
        public DateTime? StartTs { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Edate { get; set; }
        public DateTime? Bdate2 { get; set; }
        public short? StaticChId { get; set; }
        public DateTime? StaticBdate { get; set; }
        public string UserName { get; set; }
        public string AppName { get; set; }
        public string HostName { get; set; }
        public int? TimeSpentSec { get; set; }
    }
}
