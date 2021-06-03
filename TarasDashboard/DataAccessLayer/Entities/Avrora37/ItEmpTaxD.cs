using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEmpTaxD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public decimal UniSocSumCc { get; set; }
        public decimal IncomeTaxSumCc { get; set; }
        public string Notes { get; set; }
        public decimal MilitarySumCc { get; set; }
        public decimal MoreCc1 { get; set; }
    }
}
