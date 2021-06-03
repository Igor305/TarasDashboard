using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvExc
    {
        public int OurId { get; set; }
        public int NewStockId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal? Qty { get; set; }
    }
}
