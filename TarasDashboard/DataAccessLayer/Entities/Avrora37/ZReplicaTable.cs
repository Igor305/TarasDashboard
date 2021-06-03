using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaTable
    {
        public ZReplicaTable()
        {
            ZReplicaFilters = new HashSet<ZReplicaFilter>();
            ZReplicaReplaces = new HashSet<ZReplicaReplace>();
        }

        public int ReplicaPubCode { get; set; }
        public int TableCode { get; set; }
        public string LfilterExp { get; set; }
        public string EfilterExp { get; set; }
        public bool WasChanged { get; set; }

        public virtual ZReplicaPub ReplicaPubCodeNavigation { get; set; }
        public virtual ZTable TableCodeNavigation { get; set; }
        public virtual ICollection<ZReplicaFilter> ZReplicaFilters { get; set; }
        public virtual ICollection<ZReplicaReplace> ZReplicaReplaces { get; set; }
    }
}
