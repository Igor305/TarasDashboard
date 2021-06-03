using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogTool
    {
        public int LogId { get; set; }
        public DateTime DocDate { get; set; }
        public int RepToolCode { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public short UserCode { get; set; }

        public virtual ZToolRep RepToolCodeNavigation { get; set; }
    }
}
