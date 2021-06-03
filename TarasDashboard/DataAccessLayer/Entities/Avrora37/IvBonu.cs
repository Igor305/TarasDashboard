using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvBonu
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public bool InUse { get; set; }
        public string Notes { get; set; }
    }
}
