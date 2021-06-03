using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzValidTable
    {
        public string RelName { get; set; }
        public int ParentDocCode { get; set; }
        public int ParentCode { get; set; }
        public string ParentName { get; set; }
        public string ParentDesc { get; set; }
        public string ParentNames { get; set; }
        public string ParentDescs { get; set; }
        public int ChildDocCode { get; set; }
        public int ChildCode { get; set; }
        public string ChildName { get; set; }
        public string ChildDesc { get; set; }
        public string ChildNames { get; set; }
        public string ChildDescs { get; set; }
        public bool CascUpdate { get; set; }
        public bool CascDelete { get; set; }
        public int RelType { get; set; }
    }
}
