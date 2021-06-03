using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrDiscountsForEntitiesPerson
    {
        public long ChId { get; set; }
        public int PlId { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime? BdateDiscount { get; set; }
        public DateTime? EdateDiscount { get; set; }
    }
}
