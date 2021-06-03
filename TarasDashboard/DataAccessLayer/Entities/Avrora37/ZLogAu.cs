using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogAu
    {
        public int LogId { get; set; }
        public DateTime DocDate { get; set; }
        public int AugroupCode { get; set; }
        public short UserCode { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
