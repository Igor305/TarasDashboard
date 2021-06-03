using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItFlowChart
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int OurId { get; set; }
        public string IntDocId { get; set; }
        public int ProdId { get; set; }
        public decimal Qty { get; set; }
        public string OutUm { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int StateCode { get; set; }
        public string Notes { get; set; }
        public string BaseUm { get; set; }
        public decimal OutQty { get; set; }
        public int EmpId { get; set; }
        public short? CardUseFor { get; set; }
    }
}
