using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItCashRegister
    {
        public long ChId { get; set; }
        public int StockId { get; set; }
        public DateTime DocDate { get; set; }
        public decimal TotalCash { get; set; }
        public int CountedEmpId { get; set; }
        public int AdminEmpId { get; set; }
    }
}
