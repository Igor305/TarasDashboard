using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TEorecSpend
    {
        public long ChId { get; set; }
        public int SpendCode { get; set; }
        public decimal SpendSumCc { get; set; }
        public string SpendNotes { get; set; }

        public virtual TEorec Ch { get; set; }
    }
}
