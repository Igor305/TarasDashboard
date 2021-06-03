using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSest1
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal KursMc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public decimal? Tqty { get; set; }
        public decimal? TpriceAc { get; set; }
        public decimal? TnewPriceAc { get; set; }
        public decimal? Aextra { get; set; }
    }
}
