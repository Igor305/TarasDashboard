using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRlog
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public long RecDocId { get; set; }
        public long DisDocId { get; set; }
        public DateTime RecDocDate { get; set; }
        public DateTime? RecPlanEdate { get; set; }
        public DateTime? RecFactEdate { get; set; }
        public int DiffDay { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal DiffSum { get; set; }
        public decimal WrongDelivQty { get; set; }
        public decimal WrongDelivSumCc { get; set; }
        public int StateCode { get; set; }
        public string Notes { get; set; }
        public decimal WrongDisSumCc { get; set; }
        public decimal WrongShopSumCc { get; set; }
        public decimal ShortSumCc { get; set; }
    }
}
