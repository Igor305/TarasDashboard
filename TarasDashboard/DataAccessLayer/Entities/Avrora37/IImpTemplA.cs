using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IImpTemplA
    {
        public short TableId { get; set; }
        public short TemplId { get; set; }
        public string TableName { get; set; }
        public short TableOrderId { get; set; }
        public short StartLine { get; set; }
        public bool? IsDetails { get; set; }
    }
}
