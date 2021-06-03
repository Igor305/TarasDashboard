using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProcessing
    {
        public long ChId { get; set; }
        public int ProcessingId { get; set; }
        public string ProcessingName { get; set; }
        public int? ProcessingType { get; set; }
        public string Ip { get; set; }
        public int NetPort { get; set; }
        public string Path { get; set; }
        public int MaxDifference { get; set; }
        public int Multiplicity { get; set; }
        public DateTime RetryTime { get; set; }
        public int RetryPeriod { get; set; }
        public string ExtraInfo { get; set; }
    }
}
