using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PPostStrucD
    {
        public long ChId { get; set; }
        public int SrcPosId { get; set; }
        public short SubId { get; set; }
        public int PostId { get; set; }
        public int StrucPostId { get; set; }
        public decimal VacTotal { get; set; }
        public decimal VacOcc { get; set; }
        public decimal VacFree { get; set; }
        public DateTime? Edate { get; set; }
        public int StrucParentPostId { get; set; }
    }
}
