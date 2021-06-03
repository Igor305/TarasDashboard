using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItLogCalcCatEoexp
    {
        public int LogId { get; set; }
        public short UserId { get; set; }
        public string ExecStr { get; set; }
        public DateTime? LogDate { get; set; }
        public int Status { get; set; }
        public long ChId { get; set; }
    }
}
