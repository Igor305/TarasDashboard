using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItChildCompPay
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public decimal SumCcWt { get; set; }
        public string Notes { get; set; }
        public int CompId { get; set; }
        public int ChildCompId { get; set; }
        public string ChildCompName { get; set; }
        public string WaybillId { get; set; }
        public DateTime? WaybillDate { get; set; }
    }
}
