using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaField
    {
        public int ReplicaPubCode { get; set; }
        public int TableCode { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
    }
}
