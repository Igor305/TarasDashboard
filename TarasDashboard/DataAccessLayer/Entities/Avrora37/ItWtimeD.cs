using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItWtimeD
    {
        public long ChId { get; set; }
        public int EmpId { get; set; }
        public int PostId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal NormTime { get; set; }
        public decimal FactTime { get; set; }
        public decimal Wrate { get; set; }
        public decimal PersSumCc { get; set; }
        public int PersId { get; set; }
        public decimal FineSumCc { get; set; }
        public int FineId { get; set; }
        public decimal TsumCc { get; set; }
        public int SrcPosId { get; set; }
        public bool IsLeave { get; set; }
        public bool IsSickTime { get; set; }
    }
}
