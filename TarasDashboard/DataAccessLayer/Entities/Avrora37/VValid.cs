using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VValid
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public int TableIdx { get; set; }
        public int TableCode { get; set; }
        public string FieldName { get; set; }
        public int ValidTableCode { get; set; }
        public string ValidFieldName { get; set; }
    }
}
