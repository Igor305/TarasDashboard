using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ROrderMonitor
    {
        public int OrderMonitorId { get; set; }
        public string OrderMonitorName { get; set; }
        public byte OrderMonitorType { get; set; }
        public bool ShowProdNotes { get; set; }
        public int IntervalWarning { get; set; }
        public int IntervalCritical { get; set; }
        public bool InUse { get; set; }
        public string Wpidfilter { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
        public string Notes { get; set; }
    }
}
