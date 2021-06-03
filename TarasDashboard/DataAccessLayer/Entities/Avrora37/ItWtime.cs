using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItWtime
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StockId { get; set; }
        public int EmpId { get; set; }
        public int StateCode { get; set; }
        public int OurId { get; set; }
        public DateTime? FillingDate { get; set; }
    }
}
