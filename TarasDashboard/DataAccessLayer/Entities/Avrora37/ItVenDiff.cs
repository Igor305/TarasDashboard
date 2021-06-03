using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenDiff
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public decimal Tqty { get; set; }
        public decimal TnewQty { get; set; }
        public decimal? ToldQty { get; set; }
        public decimal? ToldNewQty { get; set; }
        public decimal DiffTqty { get; set; }
        public decimal DiffTnewQty { get; set; }
    }
}
