using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZUserVar
    {
        public short UserCode { get; set; }
        public string VarName { get; set; }
        public string VarDesc { get; set; }
        public string VarValue { get; set; }
        public string VarInfo { get; set; }
        public int VarType { get; set; }
        public int VarSelType { get; set; }
        public string VarGroup { get; set; }
        public int VarPosId { get; set; }
        public int LabelPos { get; set; }
        public string VarExtInfo { get; set; }
        public bool? VarVisible { get; set; }
        public string ObjectDef { get; set; }

        public virtual RUser UserCodeNavigation { get; set; }
    }
}
