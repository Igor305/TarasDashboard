using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpInc
    {
        public int OurId { get; set; }
        public int SrcPosId { get; set; }
        public int EmpId { get; set; }
        public int Priority { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public short PayTypeId { get; set; }
        public string SumExpE { get; set; }
        public string SumExpR { get; set; }
        public string Notes { get; set; }
    }
}
