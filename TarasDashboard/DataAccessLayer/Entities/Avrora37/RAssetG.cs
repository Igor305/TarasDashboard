using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RAssetG
    {
        public long ChId { get; set; }
        public int AgrId { get; set; }
        public string AgrName { get; set; }
        public string Notes { get; set; }
        public int AssGrGaccId { get; set; }
        public int AssDepGaccId { get; set; }
        public int AgrId1 { get; set; }
    }
}
