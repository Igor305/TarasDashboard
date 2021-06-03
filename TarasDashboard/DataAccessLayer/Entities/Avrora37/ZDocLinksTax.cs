using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocLinksTax
    {
        public int LinkId { get; set; }
        public decimal SumCcNt20 { get; set; }
        public decimal TaxSum20 { get; set; }
        public decimal SumCcNt0 { get; set; }
        public decimal TaxSum0 { get; set; }
        public decimal SumCcNtFree { get; set; }
        public decimal TaxSumFree { get; set; }
        public decimal SumCcNtNo { get; set; }
        public decimal TaxSumNo { get; set; }
    }
}
