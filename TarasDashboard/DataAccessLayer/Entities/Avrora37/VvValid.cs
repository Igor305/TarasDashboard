using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VvValid
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public int TableIdx { get; set; }
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public string FieldName { get; set; }
        public string FieldDesc { get; set; }
        public int ValidTableCode { get; set; }
        public string ValidTableName { get; set; }
        public string ValidTableDesc { get; set; }
        public string ValidFieldName { get; set; }
        public string ValidFieldDesc { get; set; }
    }
}
