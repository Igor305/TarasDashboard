using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRemDayProd
    {
        public int ChId { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }

        public virtual TRemDay Ch { get; set; }
    }
}
