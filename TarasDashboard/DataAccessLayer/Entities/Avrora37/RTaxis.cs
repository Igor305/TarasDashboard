using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RTaxis
    {
        public int TaxTypeId { get; set; }
        public string TaxName { get; set; }
        public string TaxDesc { get; set; }
        public byte? TaxId { get; set; }
        public string Notes { get; set; }
    }
}
