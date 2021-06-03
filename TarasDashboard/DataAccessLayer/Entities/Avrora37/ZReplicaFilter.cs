using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaFilter
    {
        public int ReplicaPubCode { get; set; }
        public int TableCode { get; set; }
        public int PtableCode { get; set; }
        public string PfieldNames { get; set; }
        public string PfieldDescs { get; set; }
        public int CtableCode { get; set; }
        public string CfieldNames { get; set; }
        public string CfieldDescs { get; set; }

        public virtual ZReplicaTable ZReplicaTable { get; set; }
    }
}
