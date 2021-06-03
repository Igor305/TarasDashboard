using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAccDef
    {
        public ZAccDef()
        {
            ZAccDefDocs = new HashSet<ZAccDefDoc>();
            ZAccDefObjects = new HashSet<ZAccDefObject>();
            ZAccDefTables = new HashSet<ZAccDefTable>();
        }

        public int AccDefCode { get; set; }
        public string AccDefName { get; set; }
        public string AccDefDesc { get; set; }

        public virtual ICollection<ZAccDefDoc> ZAccDefDocs { get; set; }
        public virtual ICollection<ZAccDefObject> ZAccDefObjects { get; set; }
        public virtual ICollection<ZAccDefTable> ZAccDefTables { get; set; }
    }
}
