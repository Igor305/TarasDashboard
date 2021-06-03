using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvEmpTax
    {
        public long ChId { get; set; }
        public int OurId { get; set; }
        public string OurName { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public decimal? UniSocSumCc { get; set; }
        public decimal? IncomeTaxSumCc { get; set; }
    }
}
