using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class AzTime
    {
        public DateTime? StartTime { get; set; }
        public int? Step { get; set; }
        public string StepTime { get; set; }
        public string Info { get; set; }
    }
}
