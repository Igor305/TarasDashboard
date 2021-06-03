using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RResourceSched
    {
        public int ResourceId { get; set; }
        public DateTime Btime { get; set; }
        public DateTime Etime { get; set; }
    }
}
