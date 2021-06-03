using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCancPrice
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public byte PriceType { get; set; }
    }
}
