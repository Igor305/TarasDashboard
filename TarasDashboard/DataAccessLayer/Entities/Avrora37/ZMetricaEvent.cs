using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZMetricaEvent
    {
        public ZMetricaEvent()
        {
            ZLogMetrics = new HashSet<ZLogMetric>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<ZLogMetric> ZLogMetrics { get; set; }
    }
}
