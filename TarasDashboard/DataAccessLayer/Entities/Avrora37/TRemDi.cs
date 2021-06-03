using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRemDi
    {
        public DateTime Date { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public int SecId { get; set; }
        public decimal? Qty { get; set; }
    }
}
