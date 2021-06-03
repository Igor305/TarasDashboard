using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEsicAsE
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int OurId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public byte SickType { get; set; }
        public string SickDocId { get; set; }
        public string SickDept { get; set; }
        public string Diagnosis { get; set; }
        public DateTime SickBdate { get; set; }
        public DateTime SickEdate { get; set; }
        public short SickWdays { get; set; }
        public short TillFiveSickWdays { get; set; }
        public decimal TillFiveSickWhours { get; set; }
        public decimal SickWhours { get; set; }
        public int? PrimSickDocId { get; set; }
        public decimal AvrSalary { get; set; }
        public decimal AvrGrantCc { get; set; }
        public decimal GrantSumCc { get; set; }
        public decimal TillFiveSumCc { get; set; }
        public decimal AfterFiveSumCc { get; set; }
        public DateTime DetSrcDate { get; set; }
        public decimal DetTillFiveSumCc { get; set; }
        public decimal DetAfterFiveSumCc { get; set; }
    }
}
