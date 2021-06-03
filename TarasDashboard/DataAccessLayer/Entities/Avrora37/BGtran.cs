using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGtran
    {
        public int GtranId { get; set; }
        public int GoperId { get; set; }
        public int DocCode { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public decimal KursMc { get; set; }
        public string IntDocId { get; set; }
        public int GposId { get; set; }
    }
}
