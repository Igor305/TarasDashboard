using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RExecutorShift
    {
        public int ExecutorId { get; set; }
        public int StockId { get; set; }
        public DateTime Btime { get; set; }
        public DateTime Etime { get; set; }
    }
}
