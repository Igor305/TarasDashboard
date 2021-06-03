using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDctype
    {
        public RDctype()
        {
            RDiscDcs = new HashSet<RDiscDc>();
        }

        public long ChId { get; set; }
        public int DctypeCode { get; set; }
        public string DctypeName { get; set; }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal InitSum { get; set; }
        public int ProdId { get; set; }
        public string Notes { get; set; }
        public int MaxQty { get; set; }
        public int DctypeGcode { get; set; }
        public bool DeactivateAfterUse { get; set; }
        public bool NoManualDcardEnter { get; set; }

        public virtual ICollection<RDiscDc> RDiscDcs { get; set; }
    }
}
