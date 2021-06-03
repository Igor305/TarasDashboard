using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VRepUser
    {
        public int RepId { get; set; }
        public short UserId { get; set; }
        public byte Apopen { get; set; }
        public byte Apedit { get; set; }
        public byte Apdelete { get; set; }
        public byte ApexportTemplate { get; set; }
        public byte ApexportReport { get; set; }

        public virtual VRep Rep { get; set; }
    }
}
