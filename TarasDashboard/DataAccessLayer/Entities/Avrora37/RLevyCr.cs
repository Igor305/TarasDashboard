using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RLevyCr
    {
        public int LevyId { get; set; }
        public short CashType { get; set; }
        public byte TaxId { get; set; }
        public decimal CrtaxPercent { get; set; }
        public bool Override { get; set; }
        public int TaxTypeId { get; set; }
    }
}
