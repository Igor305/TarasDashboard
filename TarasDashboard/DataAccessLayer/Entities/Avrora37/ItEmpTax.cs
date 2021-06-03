using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItEmpTax
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StateCode { get; set; }
    }
}
