using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TSpec
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public DateTime DocDate { get; set; }
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public string Notes { get; set; }
        public int StateCode { get; set; }
        public int ProdId { get; set; }
        public string Um { get; set; }
        public decimal OutQty { get; set; }
        public string OutUm { get; set; }
    }
}
