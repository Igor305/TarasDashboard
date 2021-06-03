using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RBserv
    {
        public long ChId { get; set; }
        public int BservId { get; set; }
        public string BservName { get; set; }
        public int BankGrId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int PayFormCode { get; set; }
        public int? PosbservId { get; set; }
        public string Notes { get; set; }
    }
}
