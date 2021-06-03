using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCompValue
    {
        public int CompId { get; set; }
        public string VarName { get; set; }
        public string VarValue { get; set; }

        public virtual RComp Comp { get; set; }
    }
}
