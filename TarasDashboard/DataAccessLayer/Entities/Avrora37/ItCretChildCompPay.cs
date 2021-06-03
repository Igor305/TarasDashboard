using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCretChildCompPay
    {
        public long ChId { get; set; }
        public int Srcposid { get; set; }
        public decimal SumccWt { get; set; }
        public string Notes { get; set; }
        public int Compid { get; set; }
        public int Childcompid { get; set; }
        public string ChildCompName { get; set; }
    }
}
