using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDocShedD
    {
        public int DocShedCode { get; set; }
        public int SrcPosId { get; set; }
        public int StateCode { get; set; }
        public int DateShift { get; set; }
        public int DateShiftPart { get; set; }
        public DateTime? PlanDate { get; set; }
        public int StateCodeFrom { get; set; }
        public short CurrId { get; set; }
        public decimal? SumAc { get; set; }
        public decimal? SumCc { get; set; }
        public bool EnterDate { get; set; }
        public decimal? SumAcperc { get; set; }
        public decimal? SumCcperc { get; set; }
        public string Notes { get; set; }
    }
}
