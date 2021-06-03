using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCrec
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public short Crid { get; set; }
        public string Subject { get; set; }
        public string Appx { get; set; }
        public string ByDoc { get; set; }
        public decimal SumCc { get; set; }
        public int EmpId { get; set; }
        public int CashEmpId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string Notes { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public int StateCode { get; set; }
        public int BookkeeperEmpId { get; set; }
        public int PrincipalEmpId { get; set; }
    }
}
