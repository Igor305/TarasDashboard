using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRedistribution
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string Notes { get; set; }
        public DateTime DocDate { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int StockId { get; set; }
        public int DestStockId { get; set; }
        public int NewStockId { get; set; }
        public decimal Qty { get; set; }
    }
}
