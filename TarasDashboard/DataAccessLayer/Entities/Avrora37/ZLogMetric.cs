using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogMetric
    {
        public int DbiId { get; set; }
        public long LogIdex { get; set; }
        public int DocCode { get; set; }
        public long ChId { get; set; }
        public short Crid { get; set; }
        public int EventId { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsFinished { get; set; }
        public string Notes { get; set; }

        public virtual ZMetricaEvent Event { get; set; }
    }
}
