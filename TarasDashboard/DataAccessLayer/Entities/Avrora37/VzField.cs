using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzField
    {
        public int DocCode { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public bool IsView { get; set; }
        public int TableCode { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldInfo { get; set; }
        public bool Required { get; set; }
        public int DataSize { get; set; }
        public string Dbdefault { get; set; }
        public string FieldDesc { get; set; }
        public byte DataType { get; set; }
        public int Sqltype { get; set; }
        public string SqltypeName { get; set; }
    }
}
