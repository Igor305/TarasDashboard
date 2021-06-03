using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEmpIn
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public DateTime WorkAppDate { get; set; }
        public DateTime? DisDate { get; set; }
        public DateTime IndexBaseMonth { get; set; }
    }
}
