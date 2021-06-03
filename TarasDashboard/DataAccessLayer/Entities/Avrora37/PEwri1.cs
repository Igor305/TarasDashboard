using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEwri1
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string WritDocId { get; set; }
        public DateTime? WritDate { get; set; }
        public string WritDept { get; set; }
        public byte WritType { get; set; }
        public DateTime WritBdate { get; set; }
        public DateTime WritEdate { get; set; }
        public decimal WritSumCc { get; set; }
        public decimal WritPrc { get; set; }
        public int AddrCompId { get; set; }
        public int AddrEmpId { get; set; }
        public byte TransType { get; set; }
        public int BankId { get; set; }
        public string AccountCc { get; set; }
        public string Notes { get; set; }
    }
}
