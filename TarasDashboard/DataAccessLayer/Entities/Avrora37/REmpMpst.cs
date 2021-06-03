using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpMpst
    {
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public short SubId { get; set; }
        public int PostId { get; set; }
        public byte EmpClass { get; set; }
        public byte WorkCond { get; set; }
        public short ShedId { get; set; }
        public byte SalaryType { get; set; }
        public byte SalaryForm { get; set; }
        public byte SalaryMethod { get; set; }
        public decimal Bsalary { get; set; }
        public decimal BsalaryPrc { get; set; }
        public decimal AdvSum { get; set; }
        public byte PensMethod { get; set; }
        public decimal? SalaryQty { get; set; }
        public bool Joint { get; set; }
        public string Notes { get; set; }
        public bool IsDisDoc { get; set; }
        public bool IsGivDoc { get; set; }
        public byte TimeNormType { get; set; }
        public short DepId { get; set; }
        public DateTime IndexBaseMonth { get; set; }
        public short LeavDays { get; set; }
        public short LeavDaysExtra { get; set; }
        public byte PensCatId { get; set; }
        public decimal IndexExtSumCc { get; set; }
        public byte GempType { get; set; }
        public int StrucPostId { get; set; }
    }
}
