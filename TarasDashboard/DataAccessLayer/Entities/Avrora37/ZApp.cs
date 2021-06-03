using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZApp
    {
        public ZApp()
        {
            ZAppDocs = new HashSet<ZAppDoc>();
            ZAppPrints = new HashSet<ZAppPrint>();
            ZAppRoles = new HashSet<ZAppRole>();
            ZAppUsers = new HashSet<ZAppUser>();
            ZToolApps = new HashSet<ZToolApp>();
            ZVars = new HashSet<ZVar>();
        }

        public int AppCode { get; set; }
        public string AppName { get; set; }
        public string AppInfo { get; set; }

        public virtual ICollection<ZAppDoc> ZAppDocs { get; set; }
        public virtual ICollection<ZAppPrint> ZAppPrints { get; set; }
        public virtual ICollection<ZAppRole> ZAppRoles { get; set; }
        public virtual ICollection<ZAppUser> ZAppUsers { get; set; }
        public virtual ICollection<ZToolApp> ZToolApps { get; set; }
        public virtual ICollection<ZVar> ZVars { get; set; }
    }
}
