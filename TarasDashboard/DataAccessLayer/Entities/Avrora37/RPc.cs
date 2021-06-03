using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPc
    {
        public RPc()
        {
            ZReplicaSubs = new HashSet<ZReplicaSub>();
        }

        public long ChId { get; set; }
        public int Pccode { get; set; }
        public string Pcname { get; set; }
        public string Host { get; set; }
        public string Notes { get; set; }
        public string Email { get; set; }
        public int? SyncBy { get; set; }
        public bool UseRas { get; set; }
        public string Rasconnection { get; set; }
        public int? NetPort { get; set; }

        public virtual ICollection<ZReplicaSub> ZReplicaSubs { get; set; }
    }
}
