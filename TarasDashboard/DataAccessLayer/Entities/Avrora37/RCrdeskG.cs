using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCrdeskG
    {
        public int DeskGcode { get; set; }
        public int Wpid { get; set; }

        public virtual RDeskG DeskGcodeNavigation { get; set; }
    }
}
