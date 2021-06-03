using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEleavD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public int LeavType { get; set; }
        public DateTime AgeBdate { get; set; }
        public DateTime AgeEdate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public short LeavDays { get; set; }
        public decimal LeavAvrSalary { get; set; }
        public decimal LeavSumCc { get; set; }
        public long AchId { get; set; }
        public short DepId { get; set; }
    }
}
