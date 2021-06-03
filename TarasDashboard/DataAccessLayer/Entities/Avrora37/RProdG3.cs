using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdG3
    {
        public long ChId { get; set; }
        public int PgrId3 { get; set; }
        public string PgrName3 { get; set; }
        public string Notes { get; set; }
        public DateTime? SaleStartDate { get; set; }
        public DateTime? SeasonPutOutDate { get; set; }
    }
}
