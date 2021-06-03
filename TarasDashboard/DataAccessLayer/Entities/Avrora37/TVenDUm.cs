using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TVenDUm
    {
        public long ChId { get; set; }
        public int DetProdId { get; set; }
        public string DetUm { get; set; }
        public decimal QtyUm { get; set; }
        public decimal Qty { get; set; }
        public decimal Tqty { get; set; }
    }
}
