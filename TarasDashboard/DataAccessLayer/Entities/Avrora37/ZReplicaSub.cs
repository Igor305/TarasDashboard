using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaSub
    {
        public ZReplicaSub()
        {
            ZReplicaConfigOuts = new HashSet<ZReplicaConfigOut>();
            ZReplicaIns = new HashSet<ZReplicaIn>();
        }

        public int ReplicaSubCode { get; set; }
        public string ReplicaSubName { get; set; }
        public int ReplicaPubCode { get; set; }
        public int PublisherCode { get; set; }
        public string Shed { get; set; }
        public string Notes { get; set; }
        public string ServiceName { get; set; }
        public bool? UseSched { get; set; }
        public int Pccode { get; set; }

        public virtual RPc PccodeNavigation { get; set; }
        public virtual ZReplicaPub ReplicaPubCodeNavigation { get; set; }
        public virtual ICollection<ZReplicaConfigOut> ZReplicaConfigOuts { get; set; }
        public virtual ICollection<ZReplicaIn> ZReplicaIns { get; set; }
    }
}
