using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PLexpsE
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
        public short SubId { get; set; }
        public short DepId { get; set; }
        public DateTime AccDate { get; set; }
        public byte LexpType { get; set; }
        public byte LexpForm { get; set; }
        public decimal LexpPrc { get; set; }
        public int EmpId { get; set; }
        public decimal LarrSumCc { get; set; }
        public decimal LrecSumCc { get; set; }
        public decimal LexpSumCc { get; set; }
        public decimal LdepSumCc { get; set; }
        public int GoperId { get; set; }
        public int GtranId { get; set; }
    }
}
