using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class UserContractSetting
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public int UserId { get; set; }
        public int? ContractId { get; set; }
        public int RoleId { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
