using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenHistory
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public decimal Tqty { get; set; }
        public decimal TnewQty { get; set; }
    }
}
