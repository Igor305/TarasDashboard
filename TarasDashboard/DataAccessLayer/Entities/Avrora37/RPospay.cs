using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPospay
    {
        public long ChId { get; set; }
        public int PospayId { get; set; }
        public string PospayName { get; set; }
        public string PospayClass { get; set; }
        public int PospayPort { get; set; }
        public int PospayTimeout { get; set; }
        public string Notes { get; set; }
        public bool UseGrpCardForDiscs { get; set; }
        public bool UseUnionCheque { get; set; }
        public int BankId { get; set; }
        public bool PrintTranInfoInCheque { get; set; }
        public string Ip { get; set; }
        public int? NetPort { get; set; }
        public bool SettleBeforeRefund { get; set; }
    }
}
