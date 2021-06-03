using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCompContact
    {
        public int CompId { get; set; }
        public string Contact { get; set; }
        public string PhoneWork { get; set; }
        public string PhoneMob { get; set; }
        public string PhoneHome { get; set; }
        public string EMail { get; set; }
        public string Job { get; set; }
        public DateTime? BirthDate { get; set; }

        public virtual RComp Comp { get; set; }
    }
}
