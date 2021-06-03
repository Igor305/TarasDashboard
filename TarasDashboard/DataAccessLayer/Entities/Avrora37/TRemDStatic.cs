using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TRemDStatic
    {
        public TRemDStatic()
        {
            TRemDStaticDs = new HashSet<TRemDStaticD>();
        }

        public short ChId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime CalcDate { get; set; }
        public short UseCount { get; set; }

        public virtual ICollection<TRemDStaticD> TRemDStaticDs { get; set; }
    }
}
