using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogScale
    {
        public int LogId { get; set; }
        public int ScaleId { get; set; }
        public DateTime? DocTime { get; set; }
        public int ScaleAction { get; set; }
        public int Status { get; set; }
        public string Msg { get; set; }
        public string Notes { get; set; }
    }
}
