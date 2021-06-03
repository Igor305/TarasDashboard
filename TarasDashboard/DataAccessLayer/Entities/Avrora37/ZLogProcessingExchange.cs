using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogProcessingExchange
    {
        public long ChId { get; set; }
        public short Crid { get; set; }
        public int ProcessingId { get; set; }
        public DateTime? DocTime { get; set; }
        public string CardInfo { get; set; }
        public string OldDcardId { get; set; }
        public string NewDcardId { get; set; }
        public string Rrn { get; set; }
        public int Status { get; set; }
    }
}
