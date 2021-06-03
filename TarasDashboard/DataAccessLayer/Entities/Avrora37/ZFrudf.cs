using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFrudf
    {
        public string OperName { get; set; }
        public string Rformula { get; set; }
        public string Eformula { get; set; }
        public string Rformula1 { get; set; }
        public string Eformula1 { get; set; }
        public string Rformula2 { get; set; }
        public string Eformula2 { get; set; }
        public string OperDesc { get; set; }
        public string ArgDesc1 { get; set; }
        public string ArgDesc2 { get; set; }
        public string ArgDesc3 { get; set; }
        public int RevId { get; set; }
    }
}
