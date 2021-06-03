using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZUserOur
    {
        public short UserId { get; set; }
        public int OurId { get; set; }
        public byte AccRead { get; set; }
        public byte AccInsert { get; set; }
        public byte AccUpdate { get; set; }
        public byte AccDelete { get; set; }
    }
}
