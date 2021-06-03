using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaConfigSent
    {
        public int ReplicaConfigId { get; set; }
        public DateTime? DocTime { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
        public string Hash { get; set; }
    }
}
