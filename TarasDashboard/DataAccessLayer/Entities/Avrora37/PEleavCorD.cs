using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEleavCorD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public int LeavType { get; set; }
        public int LeavCorType { get; set; }
        public byte LeavCorReason { get; set; }
        public DateTime AgeBdate { get; set; }
        public DateTime AgeEdate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public DateTime NewBdate { get; set; }
        public DateTime NewEdate { get; set; }
        public short LeavCorDays { get; set; }
        public short CorDays { get; set; }
        public string CorBasis { get; set; }
    }
}
