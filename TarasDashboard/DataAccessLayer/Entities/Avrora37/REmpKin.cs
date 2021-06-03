using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpKin
    {
        public int EmpId { get; set; }
        public int SrcPosId { get; set; }
        public string KinName { get; set; }
        public DateTime? KinBirthDay { get; set; }
        public byte KinRels { get; set; }
        public bool IsDependant { get; set; }
        public string KinWorkPlace { get; set; }
        public bool? IsInvalid { get; set; }
    }
}
