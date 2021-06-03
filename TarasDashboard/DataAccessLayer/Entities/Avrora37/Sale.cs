using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Sale
    {
        public long DocId { get; set; }
        public DateTime DocTime { get; set; }
        public int StockId { get; set; }
        public short Crid { get; set; }
        public string Notes { get; set; }
        public int EmpId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }
        public decimal PriceCcWt { get; set; }
    }
}
