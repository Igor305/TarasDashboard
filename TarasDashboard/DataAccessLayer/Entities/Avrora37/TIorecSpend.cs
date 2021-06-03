using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TIorecSpend
    {
        public long ChId { get; set; }
        public int SpendCode { get; set; }
        public decimal SpendSumCc { get; set; }
        public string SpendNotes { get; set; }

        public virtual TIorec Ch { get; set; }
    }
}
