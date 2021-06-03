using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdTurnOver
    {
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public decimal KoeffTurnOver { get; set; }
        public decimal SumProfitCc { get; set; }
        public decimal KoeffProfability { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
    }
}
