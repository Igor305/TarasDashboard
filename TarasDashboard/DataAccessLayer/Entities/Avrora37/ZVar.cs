using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZVar
    {
        public string VarName { get; set; }
        public string VarDesc { get; set; }
        public string VarValue { get; set; }
        public string VarInfo { get; set; }
        public int VarType { get; set; }
        public int VarPageCode { get; set; }
        public string VarGroup { get; set; }
        public int VarPosId { get; set; }
        public int LabelPos { get; set; }
        public string VarExtInfo { get; set; }
        public int VarSelType { get; set; }
        public int AppCode { get; set; }
        public string ObjectDef { get; set; }

        public virtual ZApp AppCodeNavigation { get; set; }
        public virtual ZVarPage VarPageCodeNavigation { get; set; }
    }
}
