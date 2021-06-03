using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGviewU
    {
        public int ViewId { get; set; }
        public short UserId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
