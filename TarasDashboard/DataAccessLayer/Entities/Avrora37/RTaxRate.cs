using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RTaxRate
    {
        public int TaxTypeId { get; set; }
        public DateTime ChDate { get; set; }
        public decimal TaxPercent { get; set; }
    }
}
