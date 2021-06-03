using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PTserD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string LeavePlace { get; set; }
        public DateTime LeaveDate { get; set; }
        public string ArrivalPlace { get; set; }
        public DateTime ArrivalDate { get; set; }
    }
}
