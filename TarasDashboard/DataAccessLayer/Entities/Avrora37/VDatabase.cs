using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VDatabase
    {
        public int RepId { get; set; }
        public string Dbname { get; set; }
        public bool UseDb { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
