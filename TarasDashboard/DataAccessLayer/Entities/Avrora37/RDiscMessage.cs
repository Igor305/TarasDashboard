using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDiscMessage
    {
        public int DiscCode { get; set; }
        public int SrcPosId { get; set; }
        public string LfilterExp { get; set; }
        public string EfilterExp { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
        public int Action { get; set; }
        public string Msg { get; set; }
        public bool BeforeAction { get; set; }
        public bool ContinueRun { get; set; }
    }
}
