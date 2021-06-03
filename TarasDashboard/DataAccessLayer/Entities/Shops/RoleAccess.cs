﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RoleAccess
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public string AccessKeyName { get; set; }
        public int RoleId { get; set; }
        public int AccessTypeId { get; set; }

        public virtual AccessType AccessType { get; set; }
        public virtual Role Role { get; set; }
    }
}
