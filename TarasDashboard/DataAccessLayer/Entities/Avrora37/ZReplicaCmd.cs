using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaCmd
    {
        public int LogId { get; set; }
        public DateTime? DocTime { get; set; }
        public int ReplicaCmd { get; set; }
        public int ReplicaSubCode { get; set; }
    }
}
