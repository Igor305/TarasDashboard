using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrAmd
    {
        public int Amid { get; set; }
        public int ProdId { get; set; }
        public int EmpId { get; set; }
        public short ProdType { get; set; }
        public decimal? NormRate { get; set; }
        public int DelGid { get; set; }
        public bool? IsApp { get; set; }
        public bool? IsRound { get; set; }
        public decimal? RnTo { get; set; }
        public decimal MinRem { get; set; }
        public int? PrDevOrdRec { get; set; }
    }
}
