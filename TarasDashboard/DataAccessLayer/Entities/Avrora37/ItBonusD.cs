using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItBonusD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int PcatId { get; set; }
        public int PgrId { get; set; }
        public int PgrId1 { get; set; }
        public int PgrId2 { get; set; }
        public int PgrId3 { get; set; }
        public int ProdId { get; set; }
        public int Action { get; set; }
        public decimal SumCc { get; set; }
        public decimal Brate { get; set; }
        public string Notes { get; set; }
        public string ValidStocks { get; set; }
        public int? PcatSubgroupid { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
