using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZVarsOpenAgeBeginHistory
    {
        public DateTime EventTs { get; set; }
        public DateTime? Old { get; set; }
        public DateTime? New { get; set; }
    }
}
