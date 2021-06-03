using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogProcessing
    {
        public long ChId { get; set; }
        public int DocCode { get; set; }
        public string CardInfo { get; set; }
        public string Rrn { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
    }
}
