using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpSchedExtD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public int PostId { get; set; }
        public short ShedId { get; set; }
        public string SubJob { get; set; }
        public decimal? SalaryQty { get; set; }
        public decimal Bsalary { get; set; }
        public decimal BsalaryPrc { get; set; }
        public byte TimeNormType { get; set; }
        public int SubEmpId { get; set; }
        public bool Joint { get; set; }
        public int StrucPostId { get; set; }
    }
}
