using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Ven
    {
        public long Chid { get; set; }
        public long DocId { get; set; }
        public int StockId { get; set; }
        public DateTime Docdate { get; set; }
        public int Prodid { get; set; }
        public decimal Tqty { get; set; }
        public decimal Tnewqty { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Newqty { get; set; }
    }
}
