using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TempTsalepay
    {
        public int ChId { get; set; }
        public int SrcPosId { get; set; }
        public int PayFormCode { get; set; }
        public decimal SumCcWt { get; set; }
        public string Notes { get; set; }
        public int PospayId { get; set; }
        public int? PospayDocId { get; set; }
        public string PospayRrn { get; set; }
    }
}
