using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class POpwrksE
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int WorderId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public decimal KursMc { get; set; }
        public int OurId { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public string OrderNotes { get; set; }
        public string Notes { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public short SubId { get; set; }
        public short DepId { get; set; }
        public string SumExpE { get; set; }
        public string SumExpR { get; set; }
    }
}
