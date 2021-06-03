using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaPub
    {
        public ZReplicaPub()
        {
            ZReplicaSubs = new HashSet<ZReplicaSub>();
            ZReplicaTables = new HashSet<ZReplicaTable>();
        }

        public int ReplicaPubCode { get; set; }
        public string ReplicaPubName { get; set; }
        public bool GenTriggers { get; set; }
        public string Notes { get; set; }
        public bool GenProcs { get; set; }
        public bool SyncDiscs { get; set; }
        public bool SyncUsers { get; set; }

        public virtual ICollection<ZReplicaSub> ZReplicaSubs { get; set; }
        public virtual ICollection<ZReplicaTable> ZReplicaTables { get; set; }
    }
}
