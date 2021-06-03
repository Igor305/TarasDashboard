using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItSendMessage
    {
        public long ChId { get; set; }
        public DateTime? MessCreateDate { get; set; }
        public string Message { get; set; }
        public bool? IsRead { get; set; }
        public int StockId { get; set; }
    }
}
