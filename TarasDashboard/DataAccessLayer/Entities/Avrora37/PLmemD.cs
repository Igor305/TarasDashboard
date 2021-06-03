using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLmemD
    {
        public long ChId { get; set; }
        public short SubId { get; set; }
        public int PostId { get; set; }
        public decimal VacTotal { get; set; }
        public decimal VacOcc { get; set; }
        public int SrcPosId { get; set; }
        public decimal Bsalary { get; set; }
        public decimal BextraSalary { get; set; }
        public short DepId { get; set; }
    }
}
