using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogDiscRecTemp
    {
        public int LogId { get; set; }
        public int DocCode { get; set; }
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int DiscCode { get; set; }
        public int BonusType { get; set; }
        public int SaleSrcPosId { get; set; }
        public decimal SumBonus { get; set; }
    }
}
