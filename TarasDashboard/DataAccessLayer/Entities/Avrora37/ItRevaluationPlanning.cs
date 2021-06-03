using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRevaluationPlanning
    {
        public long ChId { get; set; }
        public long Docid { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime RevaluationDate { get; set; }
        public int OurId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int StateCode { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
    }
}
