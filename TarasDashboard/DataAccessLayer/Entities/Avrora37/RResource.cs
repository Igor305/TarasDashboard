using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RResource
    {
        public long ChId { get; set; }
        public int ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int ResourceTypeId { get; set; }
        public int MaxClients { get; set; }
        public int StockId { get; set; }
        public string Notes { get; set; }
    }
}
