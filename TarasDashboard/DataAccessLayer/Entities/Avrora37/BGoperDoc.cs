using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGoperDoc
    {
        public long ChId { get; set; }
        public int GoperId { get; set; }
        public int GtaccId { get; set; }
        public int GtaxAccId { get; set; }
        public int Dscode { get; set; }
        public int Priority { get; set; }
        public int GtadvAccId { get; set; }
    }
}
