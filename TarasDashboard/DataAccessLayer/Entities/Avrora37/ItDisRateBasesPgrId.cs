using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItDisRateBasesPgrId
    {
        public long ChId { get; set; }
        public int Stockid { get; set; }
        public decimal Baserate { get; set; }
        public decimal Salesumcc { get; set; }
        public decimal Remrecsumcc { get; set; }
        public decimal Remasumcc { get; set; }
        public decimal Normremasumcc { get; set; }
        public int Pgrid { get; set; }
    }
}
