using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ROursAc
    {
        public int OurId { get; set; }
        public int BankId { get; set; }
        public string AccountAc { get; set; }
        public bool DefaultAccount { get; set; }
        public string Notes { get; set; }
        public int GaccId { get; set; }
        public string Ibancode { get; set; }
    }
}
