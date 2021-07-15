using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItPercentDeliveryHistory
    {
        public DateTime OnDate { get; set; }
        public int? ShopIsWork { get; set; }
        public decimal? Delivery { get; set; }
    }
}
