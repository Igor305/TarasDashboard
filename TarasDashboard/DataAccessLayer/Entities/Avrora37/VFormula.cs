using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VFormula
    {
        public int RepId { get; set; }
        public short SourceId { get; set; }
        public string FieldName { get; set; }
        public bool UseTables { get; set; }
        public string Lexp { get; set; }
        public string Eexp { get; set; }
    }
}
