using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class Contract
    {
        public Contract()
        {
            ShopContracts = new HashSet<ShopContract>();
            UserContractSettings = new HashSet<UserContractSetting>();
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public string ContractName { get; set; }

        public virtual ICollection<ShopContract> ShopContracts { get; set; }
        public virtual ICollection<UserContractSetting> UserContractSettings { get; set; }
    }
}
