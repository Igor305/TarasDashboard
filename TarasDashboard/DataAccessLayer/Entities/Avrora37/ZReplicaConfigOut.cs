using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaConfigOut
    {
        public long ReplicaEventId { get; set; }
        public int TableCode { get; set; }
        public DateTime? DocTime { get; set; }
        public string Idfields { get; set; }
        public string Idvalue { get; set; }
        public int ReplEventType { get; set; }
        public int ReplicaSubCode { get; set; }
        public int? ReplicaConfigId { get; set; }

        public virtual ZReplicaSub ReplicaSubCodeNavigation { get; set; }
    }
}
