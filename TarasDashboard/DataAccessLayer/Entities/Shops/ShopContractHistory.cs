﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ShopContractHistory
    {
        public int Id { get; set; }
        public string UpdatedByUser { get; set; }
        public string FieldName { get; set; }
        public string FieldOldValue { get; set; }
        public string FieldNewValue { get; set; }
        public DateTime UpdateDate { get; set; }
        public string TransactionId { get; set; }
        public int ShopId { get; set; }
        public int ContractId { get; set; }
    }
}
