using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RSpend
    {
        public long ChId { get; set; }
        public int SpendCode { get; set; }
        public string SpendName { get; set; }
        public string Notes { get; set; }
    }
}
