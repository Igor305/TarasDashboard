using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TDisSpend
    {
        public long ChId { get; set; }
        public int SpendCode { get; set; }
        public decimal SpendSumCc { get; set; }
        public string SpendNotes { get; set; }

        public virtual TDi Ch { get; set; }
    }
}
