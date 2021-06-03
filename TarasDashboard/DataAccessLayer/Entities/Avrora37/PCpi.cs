using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCpi
    {
        public short YearId { get; set; }
        public short MonthId { get; set; }
        public decimal Cpi { get; set; }
    }
}
