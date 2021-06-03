using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogCashReg
    {
        public int LogId { get; set; }
        public short Crid { get; set; }
        public DateTime? DocTime { get; set; }
        public int CashRegAction { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
        public string Notes { get; set; }
    }
}
