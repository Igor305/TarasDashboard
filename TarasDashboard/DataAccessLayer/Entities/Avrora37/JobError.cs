using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class JobError
    {
        public string JobName { get; set; }
        public string StepName { get; set; }
        public string RunDate { get; set; }
        public string RunTime { get; set; }
        public string Server { get; set; }
        public string Message { get; set; }
    }
}
