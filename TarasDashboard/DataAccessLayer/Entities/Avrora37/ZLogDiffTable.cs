using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLogDiffTable
    {
        public DateTime? Docdate { get; set; }
        public string ExecSql { get; set; }
        public string Tablename { get; set; }
        public int? DatatimeMs { get; set; }
    }
}
