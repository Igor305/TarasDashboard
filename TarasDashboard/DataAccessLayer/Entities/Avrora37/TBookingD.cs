using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TBookingD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int SrvcId { get; set; }
        public int ResourceId { get; set; }
        public DateTime Btime { get; set; }
        public DateTime Etime { get; set; }
        public int? DetSrcPosId { get; set; }
        public bool ForRet { get; set; }
    }
}
