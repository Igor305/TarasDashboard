using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogRProdsClass
    {
        public long LogId { get; set; }
        public DateTime LogDate { get; set; }
        public int ProdId { get; set; }
        public int PcatId { get; set; }
        public int? PgrId { get; set; }
        public int? PgrId1 { get; set; }
        public int? PgrId2 { get; set; }
        public int? PgrId3 { get; set; }
        public string UserName { get; set; }
        public int OldPcatId { get; set; }
        public int? OldPgrId { get; set; }
        public int? OldPgrId1 { get; set; }
        public int? OldPgrId2 { get; set; }
        public int? OldPgrId3 { get; set; }
        public int? Pcatsubgroupid { get; set; }
        public int? OldPcatsubgroupid { get; set; }
    }
}
