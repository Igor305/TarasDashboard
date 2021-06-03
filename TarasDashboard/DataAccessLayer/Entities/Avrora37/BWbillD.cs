using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BWbillD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string JobDesc { get; set; }
        public string SubordDesc { get; set; }
        public DateTime? IntStartTime { get; set; }
        public DateTime? IntEndTime { get; set; }
        public string LoadPoint { get; set; }
        public string UnLoadPoint { get; set; }
    }
}
