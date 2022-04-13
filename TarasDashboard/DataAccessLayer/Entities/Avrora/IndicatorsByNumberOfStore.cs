using System;

#nullable disable

namespace DataAccessLayer.Entities.Avrora
{
    public partial class IndicatorsByNumberOfStore
    {
        public DateTime Date { get; set; }
        public int? SaleCount { get; set; }
        public int? ReceivedCount { get; set; }
    }
}
