using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaConfigIn
    {
        public int ReplicaConfigId { get; set; }
        public int ReplicaSubCode { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
        public DateTime? DocTime { get; set; }
        public string Hash { get; set; }
    }
}
