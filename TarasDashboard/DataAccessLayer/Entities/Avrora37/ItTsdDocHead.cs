using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItTsdDocHead
    {
        public int IdDoc { get; set; }
        public string DocNumber { get; set; }
        public DateTime? DocDate { get; set; }
        public int DocType { get; set; }
        public int? IdContragent { get; set; }
        public int? DocState { get; set; }
        public int? IdUser { get; set; }
    }
}
