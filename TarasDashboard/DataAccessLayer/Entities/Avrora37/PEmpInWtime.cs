using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpInWtime
    {
        public long ChId { get; set; }
        public DateTime SrcDate { get; set; }
        public decimal TworkHours { get; set; }
        public decimal TworkDays { get; set; }
    }
}
