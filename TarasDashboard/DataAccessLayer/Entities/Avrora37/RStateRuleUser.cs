using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RStateRuleUser
    {
        public int StateRuleCode { get; set; }
        public short UserCode { get; set; }

        public virtual RUser UserCodeNavigation { get; set; }
    }
}
