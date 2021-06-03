using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IvFlowChart
    {
        public long ChId { get; set; }
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int OurId { get; set; }
        public long DocId { get; set; }
        public string IntDocId { get; set; }
        public decimal OutQty { get; set; }
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public string Notes { get; set; }
        public bool? Active { get; set; }
    }
}
