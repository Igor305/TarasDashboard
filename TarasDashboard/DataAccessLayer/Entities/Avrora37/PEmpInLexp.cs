using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpInLexp
    {
        public long ChId { get; set; }
        public DateTime AccDate { get; set; }
        public decimal LexpSumCc { get; set; }
    }
}
