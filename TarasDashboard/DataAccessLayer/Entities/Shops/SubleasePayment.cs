using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class SubleasePayment
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public int PaymentYear { get; set; }
        public string PaymentMonth { get; set; }
        public decimal PaymentSum { get; set; }
        public string Comment { get; set; }
        public int SubleaseId { get; set; }
        public int MonthNumber { get; set; }

        public virtual Sublease Sublease { get; set; }
    }
}
