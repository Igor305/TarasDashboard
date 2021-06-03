using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BTranE1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime? DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal? TsumCc { get; set; }
        public decimal? TsumMc { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal? TsumCc1 { get; set; }
        public decimal? TsumMc1 { get; set; }
    }
}
