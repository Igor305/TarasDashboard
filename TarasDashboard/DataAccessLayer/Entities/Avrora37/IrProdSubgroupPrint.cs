using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrProdSubgroupPrint
    {
        public long ChId { get; set; }
        public int PcatSubgroupid { get; set; }
        public string Pcatsubgroupname { get; set; }
        public string Notes { get; set; }
    }
}
