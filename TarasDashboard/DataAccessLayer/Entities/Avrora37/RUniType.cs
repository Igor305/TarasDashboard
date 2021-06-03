using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RUniType
    {
        public long ChId { get; set; }
        public int RefTypeId { get; set; }
        public string RefTypeName { get; set; }
        public string Notes { get; set; }
    }
}
