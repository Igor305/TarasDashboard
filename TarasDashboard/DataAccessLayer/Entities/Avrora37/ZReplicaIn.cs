using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaIn
    {
        public long ReplicaEventId { get; set; }
        public int ReplicaSubCode { get; set; }
        public string ExecStr { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
        public DateTime DocTime { get; set; }

        public virtual ZReplicaSub ReplicaSubCodeNavigation { get; set; }
    }
}
