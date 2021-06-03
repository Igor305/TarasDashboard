using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFieldsRepGrp
    {
        public ZFieldsRepGrp()
        {
            ZFieldsReps = new HashSet<ZFieldsRep>();
        }

        public int FieldsRepGrpCode { get; set; }
        public string FieldsRepGrpName { get; set; }
        public string FieldsRepGrpInfo { get; set; }

        public virtual ICollection<ZFieldsRep> ZFieldsReps { get; set; }
    }
}
