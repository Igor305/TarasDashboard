using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCompsChild
    {
        public int ChildCompId { get; set; }
        public string ChildCompName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? MainComp { get; set; }
        public string TaxCode { get; set; }
        public int PayFormCode { get; set; }
        public short CompType { get; set; }
        public string CompAccountCc { get; set; }
        public int CompId { get; set; }
    }
}
