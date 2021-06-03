using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VcPlanExp
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public int StockId { get; set; }
        public string StockName { get; set; }
        public int CompId { get; set; }
        public string CompName { get; set; }
        public short CurrId { get; set; }
        public string CurrName { get; set; }
        public decimal SumAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal? SumMc { get; set; }
        public decimal KursCc { get; set; }
        public decimal? SumCc { get; set; }
        public string Subject { get; set; }
        public short CodeId1 { get; set; }
        public string CodeName1 { get; set; }
        public short CodeId2 { get; set; }
        public string CodeName2 { get; set; }
        public short CodeId3 { get; set; }
        public string CodeName3 { get; set; }
        public short CodeId4 { get; set; }
        public string CodeName4 { get; set; }
        public short CodeId5 { get; set; }
        public string CodeName5 { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
    }
}
