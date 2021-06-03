using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDep
    {
        public long ChId { get; set; }
        public string DepName { get; set; }
        public string Notes { get; set; }
        public short DepId { get; set; }
    }
}
