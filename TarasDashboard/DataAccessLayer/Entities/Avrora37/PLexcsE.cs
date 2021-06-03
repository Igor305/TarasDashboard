using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLexcsE
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int WorderId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime ExcDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int? EmpId { get; set; }
        public short? SubId { get; set; }
        public short? DepId { get; set; }
        public int? PostId { get; set; }
        public byte? EmpClass { get; set; }
        public short? ShedId { get; set; }
        public byte? WorkCond { get; set; }
        public string SubJob { get; set; }
        public decimal? SalaryQty { get; set; }
        public byte? SalaryType { get; set; }
        public byte? SalaryForm { get; set; }
        public byte? SalaryMethod { get; set; }
        public decimal? Bsalary { get; set; }
        public decimal? BsalaryPrc { get; set; }
        public byte? TimeNormType { get; set; }
        public byte? PensMethod { get; set; }
        public byte? PensCatId { get; set; }
    }
}
