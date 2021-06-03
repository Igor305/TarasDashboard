using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpMp
    {
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public int SrcPosId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public int PrevId { get; set; }
        public bool IsPensioner { get; set; }
        public bool IsInvalid { get; set; }
        public string PrivDesc { get; set; }
        public string PrevReason { get; set; }
        public byte DisGroup { get; set; }
    }
}
