using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCity
    {
        public long ChId { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string Notes { get; set; }
    }
}
