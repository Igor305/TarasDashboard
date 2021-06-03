using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZReplicaOut
    {
        public long ReplicaEventId { get; set; }
        public int ReplicaSubCode { get; set; }
        public DateTime DocTime { get; set; }
        public int TableCode { get; set; }
        public int ReplEventType { get; set; }
        public string Pkfields { get; set; }
        public string Pkvalue { get; set; }
        public string ChangeFields { get; set; }
        public string ChangeFieldValues { get; set; }
        public byte Status { get; set; }
        public string Msg { get; set; }
    }
}
