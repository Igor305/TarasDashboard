using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRemDStaticD
    {
        public short ChId { get; set; }
        public byte OurId { get; set; }
        public int StockId { get; set; }
        public int ProdId { get; set; }
        public byte SecId { get; set; }
        public int Ppid { get; set; }
        public decimal? Qty { get; set; }
        public decimal? AccQty { get; set; }

        public virtual TRemDStatic Ch { get; set; }
    }
}
