using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaExchangeLog
    {
        public long ChId { get; set; }
        public int? ReplicaSubCode { get; set; }
        public int? Pccode { get; set; }
        public int? Mode { get; set; }
        public DateTime? ExchangeStartTime { get; set; }
        public DateTime? DocTime { get; set; }
        public long? MaxExchangedEventId { get; set; }
        public long? LastProcessedEventId { get; set; }
        public long? LastEventCount { get; set; }
        public long? LastSessionBytesExchanged { get; set; }
        public int? Result { get; set; }
        public string Msg { get; set; }
    }
}
