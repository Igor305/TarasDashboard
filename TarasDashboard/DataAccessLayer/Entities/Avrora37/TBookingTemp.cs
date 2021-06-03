using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TBookingTemp
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public int? OrderId { get; set; }
        public DateTime DocCreateTime { get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
