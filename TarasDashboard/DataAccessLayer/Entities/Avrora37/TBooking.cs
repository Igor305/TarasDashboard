using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TBooking
    {
        public long ChId { get; set; }
        public DateTime DocDate { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public int? OrderId { get; set; }
        public int PersonId { get; set; }
        public int StateCode { get; set; }
        public int DocCode { get; set; }
        public long DocChId { get; set; }
    }
}
