using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ROper
    {
        public long ChId { get; set; }
        public int OperId { get; set; }
        public string OperName { get; set; }
        public int OperPwd { get; set; }
        public int EmpId { get; set; }
        public string OperLockPwd { get; set; }
    }
}
