using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RState
    {
        public long ChId { get; set; }
        public int StateCode { get; set; }
        public string StateName { get; set; }
        public string StateInfo { get; set; }
        public bool CanChangeDoc { get; set; }
    }
}
