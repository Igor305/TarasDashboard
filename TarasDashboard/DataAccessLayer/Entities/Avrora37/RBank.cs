using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RBank
    {
        public long ChId { get; set; }
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string Address { get; set; }
        public string PostIndex { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int BankGrId { get; set; }
        public string Swiftbiccode { get; set; }
    }
}
