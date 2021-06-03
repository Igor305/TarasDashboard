using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStateRule
    {
        public int StateRuleCode { get; set; }
        public string Notes { get; set; }
        public int StateCodeFrom { get; set; }
        public int StateCodeTo { get; set; }
        public bool DenyUsers { get; set; }
    }
}
