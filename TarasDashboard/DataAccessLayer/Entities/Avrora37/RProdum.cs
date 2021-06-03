using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdum
    {
        public long ChId { get; set; }
        public short PgrAid { get; set; }
        public string PgrAname { get; set; }
        public string Notes { get; set; }
    }
}
