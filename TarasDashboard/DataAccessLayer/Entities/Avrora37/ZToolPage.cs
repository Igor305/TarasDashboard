using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZToolPage
    {
        public int ToolCode { get; set; }
        public int PageIndex { get; set; }
        public string PageName { get; set; }
        public int PageStyle { get; set; }
        public bool PageVisible { get; set; }
        public string Sqlstr { get; set; }
        public int Sqltype { get; set; }
        public string IntName { get; set; }

        public virtual ZTool ToolCodeNavigation { get; set; }
    }
}
