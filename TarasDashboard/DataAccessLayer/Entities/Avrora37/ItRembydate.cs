using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRembydate
    {
        public string Name { get; set; }
        public int? Dbiid { get; set; }
        public int? OurId { get; set; }
        public int? StockId { get; set; }
        public decimal? Sum { get; set; }
        public string BegDate { get; set; }
        public string EndDate { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
