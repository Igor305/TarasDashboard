using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZField
    {
        public int TableCode { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldInfo { get; set; }
        public bool Required { get; set; }
        public int DataSize { get; set; }
        public string Dbdefault { get; set; }

        public virtual ZFieldsRep FieldNameNavigation { get; set; }
        public virtual ZTable TableCodeNavigation { get; set; }
    }
}
