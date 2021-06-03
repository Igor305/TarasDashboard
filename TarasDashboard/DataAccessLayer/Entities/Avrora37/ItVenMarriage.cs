using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItVenMarriage
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public string Barcode { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal TnewQty { get; set; }
        public decimal TnewSumCcNt { get; set; }
    }
}
