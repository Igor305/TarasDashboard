using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCurrD
    {
        public short CurrId { get; set; }
        public int NomValue { get; set; }
        public byte[] Picture { get; set; }
        public bool Visible { get; set; }
        public bool AskPwdBanknote { get; set; }
    }
}
