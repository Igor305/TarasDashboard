using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZContract
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public int OurId { get; set; }
        public string AccountCc { get; set; }
        public string AccountAc { get; set; }
        public int CompId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public short CurrId { get; set; }
        public decimal SumCc { get; set; }
        public decimal SumAc { get; set; }
        public string CompAccountCc { get; set; }
        public string CompAccountAc { get; set; }
        public string Notes { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public string File1 { get; set; }
        public string File2 { get; set; }
        public string File3 { get; set; }
        public string SrcDocId { get; set; }
        public decimal Discount { get; set; }
        public short PayDelay { get; set; }
        public string IntDocId { get; set; }
        public DateTime? Edate { get; set; }
        public int CivilContractType { get; set; }
    }
}
