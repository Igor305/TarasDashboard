using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaReplace
    {
        public int ReplicaPubCode { get; set; }
        public int TableCode { get; set; }
        public string FieldName { get; set; }
        public string Lexp { get; set; }
        public string Eexp { get; set; }

        public virtual ZFieldsRep FieldNameNavigation { get; set; }
        public virtual ZReplicaTable ZReplicaTable { get; set; }
    }
}
