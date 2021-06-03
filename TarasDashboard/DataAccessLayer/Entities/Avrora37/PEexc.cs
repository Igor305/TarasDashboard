﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEexc
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public int PostId { get; set; }
        public byte EmpClass { get; set; }
        public short ShedId { get; set; }
        public byte WorkCond { get; set; }
        public string SubJob { get; set; }
        public decimal? SalaryQty { get; set; }
        public byte SalaryType { get; set; }
        public byte SalaryForm { get; set; }
        public byte SalaryMethod { get; set; }
        public decimal Bsalary { get; set; }
        public decimal BsalaryPrc { get; set; }
        public byte TimeNormType { get; set; }
        public byte PensMethod { get; set; }
        public int WorderId { get; set; }
        public short DepId { get; set; }
        public DateTime ExcDate { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public DateTime IndexBaseMonth { get; set; }
        public short LeavDays { get; set; }
        public short LeavDaysExtra { get; set; }
        public byte PensCatId { get; set; }
        public bool Joint { get; set; }
        public byte GempType { get; set; }
        public byte ContractType { get; set; }
        public string ContractFile { get; set; }
        public DateTime? ContrEdate { get; set; }
        public int DecreeEmpId { get; set; }
        public int StrucPostId { get; set; }
    }
}
