using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaState
    {
        public int ReplicaSubCode { get; set; }
        public int Pccode { get; set; }
        public bool IsPublisher { get; set; }
        public DateTime DocTime { get; set; }
        public DateTime? LastFullSync { get; set; }
        public long? MaxExchangedEventId { get; set; }
        public long? LastProcessedEventId { get; set; }
        public long? LastEventCount { get; set; }
        public long? LastSessionBytesExchanged { get; set; }
        public int? LastResult { get; set; }
        public string LastErrorMsg { get; set; }
    }
}
