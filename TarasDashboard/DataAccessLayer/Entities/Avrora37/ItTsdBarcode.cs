using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItTsdBarcode
    {
        public string Barcode { get; set; }
        public int IdGood { get; set; }
        public double Count { get; set; }
        public string Tsdsn { get; set; }
        public DateTime? Date { get; set; }
        public string Comment { get; set; }
    }
}
