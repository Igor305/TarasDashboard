using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEsicA
    {
        public long ChId { get; set; }
        public DateTime DetSrcDate { get; set; }
        public decimal DetTillFiveSumCc { get; set; }
        public decimal DetAfterFiveSumCc { get; set; }
    }
}
