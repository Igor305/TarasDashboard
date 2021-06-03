using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Sublease
    {
        public Sublease()
        {
            SubleasePayments = new HashSet<SubleasePayment>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public string ContactPerson { get; set; }
        public string SubleasePurpose { get; set; }
        public decimal? PaymentSum { get; set; }
        public string Discount { get; set; }
        public string SubleaseGrounds { get; set; }
        public string SubleaseText { get; set; }
        public string PaymentUp { get; set; }
        public string PaymentOf { get; set; }
        public DateTime? ContractTerm { get; set; }
        public bool? Prolongation { get; set; }
        public string Comments { get; set; }
        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
        public virtual ICollection<SubleasePayment> SubleasePayments { get; set; }
    }
}
