using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TMonIntRec1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public short Crid { get; set; }
        public string Crname { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public decimal SumCc { get; set; }
        public string Notes { get; set; }
        public int OperId { get; set; }
        public DateTime DocTime { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int StateCode { get; set; }
        public string IntDocId { get; set; }
        public int StockId { get; set; }
    }
}
