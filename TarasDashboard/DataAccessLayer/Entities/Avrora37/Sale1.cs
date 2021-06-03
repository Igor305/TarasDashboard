using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Sale1
    {
        public long Id { get; set; }
        public string DateId { get; set; }
        public int TypeId { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public short CashRegisterId { get; set; }
        public int EmployeeId { get; set; }
        public long? DiscountCardId { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? PriceProcurement { get; set; }
        public decimal? PriceSelling { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Sum { get; set; }
    }
}
