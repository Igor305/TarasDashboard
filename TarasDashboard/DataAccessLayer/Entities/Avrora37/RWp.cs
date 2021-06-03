using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RWp
    {
        public RWp()
        {
            TOrderMonitorsTemps = new HashSet<TOrderMonitorsTemp>();
        }

        public long ChId { get; set; }
        public int Wpid { get; set; }
        public string Wpname { get; set; }
        public string Notes { get; set; }
        public int WproleId { get; set; }
        public short Crid { get; set; }
        public int ScaleId { get; set; }
        public bool CollectMetrics { get; set; }
        public int MetricMaxDays { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool? AllowChequeClose { get; set; }
        public bool ShowClientMonitor { get; set; }

        public virtual ICollection<TOrderMonitorsTemp> TOrderMonitorsTemps { get; set; }
    }
}
