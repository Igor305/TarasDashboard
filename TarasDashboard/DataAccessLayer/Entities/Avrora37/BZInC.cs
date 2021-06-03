using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BZInC
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public string CompAccountCc { get; set; }
        public short CurrId { get; set; }
        public decimal SumAc { get; set; }
        public decimal KursMc { get; set; }
        public decimal KursCc { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
        public string Notes { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
    }
}
