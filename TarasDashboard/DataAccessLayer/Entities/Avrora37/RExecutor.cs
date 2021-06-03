using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RExecutor
    {
        public long ChId { get; set; }
        public int ExecutorId { get; set; }
        public string ExecutorName { get; set; }
        public int EmpId { get; set; }
    }
}
