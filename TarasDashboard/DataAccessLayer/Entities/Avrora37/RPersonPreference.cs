using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPersonPreference
    {
        public int PersonId { get; set; }
        public int ExecutorId { get; set; }
        public int SrvcId { get; set; }
        public int ResourceId { get; set; }
        public string Notes { get; set; }
    }
}
