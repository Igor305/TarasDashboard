using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDeskG
    {
        public RDeskG()
        {
            RCrdeskGs = new HashSet<RCrdeskG>();
        }

        public long ChId { get; set; }
        public int DeskGcode { get; set; }
        public string DeskGname { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<RCrdeskG> RCrdeskGs { get; set; }
    }
}
