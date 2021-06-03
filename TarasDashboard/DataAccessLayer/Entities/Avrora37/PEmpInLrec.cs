using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpInLrec
    {
        public long ChId { get; set; }
        public DateTime AccDate { get; set; }
        public short PayTypeId { get; set; }
        public decimal LrecSumCc { get; set; }
    }
}
