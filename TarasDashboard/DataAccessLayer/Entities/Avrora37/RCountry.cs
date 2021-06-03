using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCountry
    {
        public long ChId { get; set; }
        public short CounId { get; set; }
        public string Country { get; set; }
        public string Uacountry { get; set; }
        public string CountryCode2 { get; set; }
        public string CountryCode3 { get; set; }
        public string Notes { get; set; }
    }
}
