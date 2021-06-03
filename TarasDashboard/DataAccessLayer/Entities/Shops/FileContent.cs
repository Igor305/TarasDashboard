﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class FileContent
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string LastUpdateByUserId { get; set; }
        public byte[] Content { get; set; }
        public int? FileId { get; set; }

        public virtual File File { get; set; }
    }
}
