using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItProce
    {
        public string ProgramName { get; set; }
        public string Command { get; set; }
        public int? Count { get; set; }
        public DateTime Date { get; set; }
    }
}
