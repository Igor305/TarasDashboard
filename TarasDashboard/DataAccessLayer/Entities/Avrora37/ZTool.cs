using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZTool
    {
        public ZTool()
        {
            ZToolApps = new HashSet<ZToolApp>();
            ZToolDocs = new HashSet<ZToolDoc>();
            ZToolFields = new HashSet<ZToolField>();
            ZToolPages = new HashSet<ZToolPage>();
            ZToolUserEvents = new HashSet<ZToolUserEvent>();
        }

        public int RepToolCode { get; set; }
        public int ToolCode { get; set; }
        public string ToolName { get; set; }
        public int DocCode { get; set; }
        public string ExecStr { get; set; }
        public string ConfirmText { get; set; }
        public string CompleteText { get; set; }
        public bool RefreshOnComplete { get; set; }
        public string ShortCut { get; set; }

        public virtual ZToolRep RepToolCodeNavigation { get; set; }
        public virtual ICollection<ZToolApp> ZToolApps { get; set; }
        public virtual ICollection<ZToolDoc> ZToolDocs { get; set; }
        public virtual ICollection<ZToolField> ZToolFields { get; set; }
        public virtual ICollection<ZToolPage> ZToolPages { get; set; }
        public virtual ICollection<ZToolUserEvent> ZToolUserEvents { get; set; }
    }
}
