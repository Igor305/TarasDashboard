using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BPcost1
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public short CodeId1 { get; set; }
        public decimal TnewSumCcNt { get; set; }
        public decimal TexpCostCc { get; set; }
        public decimal TexpPosProdCostCc { get; set; }
        public decimal TexpPosCostCc { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string Notes { get; set; }
        public int StateCode { get; set; }
    }
}
