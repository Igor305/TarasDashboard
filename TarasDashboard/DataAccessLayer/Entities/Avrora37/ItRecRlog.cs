using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItRecRlog
    {
        public long ChId { get; set; }
        public long? ChildChId { get; set; }
        public string ChildDocId { get; set; }
        public bool IsCalc { get; set; }
        public long DocId { get; set; }
    }
}
