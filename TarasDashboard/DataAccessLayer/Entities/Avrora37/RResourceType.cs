using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RResourceType
    {
        public long ChId { get; set; }
        public int ResourceTypeId { get; set; }
        public string ResourceTypeName { get; set; }
        public string Notes { get; set; }
    }
}
