using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RExecutorService
    {
        public int ExecutorId { get; set; }
        public int SrvcId { get; set; }
        public int MaxClients { get; set; }
    }
}
