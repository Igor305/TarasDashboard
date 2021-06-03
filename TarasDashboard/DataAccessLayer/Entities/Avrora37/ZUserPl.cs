using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZUserPl
    {
        public short UserId { get; set; }
        public int Plid { get; set; }
        public byte AccRead { get; set; }
        public byte AccInsert { get; set; }
        public byte AccUpdate { get; set; }
        public byte AccDelete { get; set; }
    }
}
