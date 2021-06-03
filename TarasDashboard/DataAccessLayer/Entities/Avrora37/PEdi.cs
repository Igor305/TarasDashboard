using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PEdi
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime DisDate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short SubId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public int DisReason { get; set; }
        public decimal DisPayCc { get; set; }
        public string DisBasis { get; set; }
        public decimal AvrSalPres { get; set; }
        public bool SaveAvrSal { get; set; }
        public DateTime? AvrSalDate { get; set; }
        public decimal? AvrNleaCc { get; set; }
        public short NleaDays { get; set; }
        public DateTime? NleaBdate { get; set; }
        public DateTime? NleaEdate { get; set; }
        public int WorderId { get; set; }
        public short DepId { get; set; }
        public string IntDocId { get; set; }
        public int StateCode { get; set; }
        public short NleaDaysExtra { get; set; }
    }
}
