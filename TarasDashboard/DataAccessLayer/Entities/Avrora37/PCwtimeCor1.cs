using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PCwtimeCor1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public byte WtsignId { get; set; }
        public string Notes { get; set; }
        public int StateCode { get; set; }
    }
}
