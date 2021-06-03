using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenTsd
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string BarCode { get; set; }
        public int? ProdId { get; set; }
        public string Tsdsn { get; set; }
        public decimal Qty { get; set; }
        public DateTime? Date { get; set; }
        public bool? Brak { get; set; }
    }
}
