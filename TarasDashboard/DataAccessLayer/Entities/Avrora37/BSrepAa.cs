using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BSrepAa
    {
        public int SelType { get; set; }
        public long ChId { get; set; }
        public int OurId { get; set; }
        public int CompId { get; set; }
        public DateTime DocDate { get; set; }
        public byte RepType { get; set; }
        public short CodeId1 { get; set; }
        public short CodeId2 { get; set; }
        public short CodeId3 { get; set; }
        public short CodeId4 { get; set; }
        public short CodeId5 { get; set; }
        public int AssId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string CompName { get; set; }
        public decimal? FsumCcWt { get; set; }
        public decimal? FsumMcWt { get; set; }
        public decimal? FsumCcNt { get; set; }
        public decimal? FsumMcNt { get; set; }
        public decimal? FtaxSumCc { get; set; }
        public decimal? FtaxSumMc { get; set; }
    }
}
