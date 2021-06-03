using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDiscDc
    {
        public int DiscCode { get; set; }
        public int DctypeCode { get; set; }
        public bool ForRec { get; set; }
        public bool ForExp { get; set; }

        public virtual RDctype DctypeCodeNavigation { get; set; }
        public virtual RDisc DiscCodeNavigation { get; set; }
    }
}
