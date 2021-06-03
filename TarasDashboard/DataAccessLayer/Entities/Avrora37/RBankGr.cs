using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RBankGr
    {
        public long ChId { get; set; }
        public int BankGrId { get; set; }
        public string BankGrName { get; set; }
        public string Notes { get; set; }
    }
}
