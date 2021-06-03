using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolField
    {
        public int ToolCode { get; set; }
        public string FieldName { get; set; }

        public virtual ZFieldsRep FieldNameNavigation { get; set; }
        public virtual ZTool ToolCodeNavigation { get; set; }
    }
}
