using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItWorkTime
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public int StockId { get; set; }
        public DateTime DocDate { get; set; }
        public int Statecode { get; set; }
    }
}
