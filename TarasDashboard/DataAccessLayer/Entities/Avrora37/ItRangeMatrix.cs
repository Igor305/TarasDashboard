using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRangeMatrix
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int EmpId { get; set; }
        public int StateCode { get; set; }
        public string Notes { get; set; }
        public int ShopFid { get; set; }
    }
}
