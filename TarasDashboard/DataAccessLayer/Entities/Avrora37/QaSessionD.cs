using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class QaSessionD
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public int? ProdId { get; set; }
        public int? Qty { get; set; }
        public int? QtyQa { get; set; }
        public int? QtyReject { get; set; }
    }
}
