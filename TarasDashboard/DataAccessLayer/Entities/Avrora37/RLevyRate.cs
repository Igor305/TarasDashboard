using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RLevyRate
    {
        public int LevyId { get; set; }
        public DateTime ChDate { get; set; }
        public decimal LevyPercent { get; set; }
    }
}
