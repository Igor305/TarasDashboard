using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPayTypeCat
    {
        public long ChId { get; set; }
        public short PayTypeCatId { get; set; }
        public string PayTypeCatName { get; set; }
        public string Notes { get; set; }
    }
}
