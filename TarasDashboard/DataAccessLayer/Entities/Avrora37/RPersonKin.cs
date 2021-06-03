using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPersonKin
    {
        public int PersonId { get; set; }
        public int SrcPosId { get; set; }
        public string KinName { get; set; }
        public DateTime? KinBirthday { get; set; }
        public byte KinRels { get; set; }
    }
}
