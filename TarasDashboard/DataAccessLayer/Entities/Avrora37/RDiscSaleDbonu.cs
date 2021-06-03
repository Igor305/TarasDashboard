using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDiscSaleDbonu
    {
        public int DiscCode { get; set; }
        public int SrcPosId { get; set; }
        public int DetSrcPosId { get; set; }
        public string BonusTypeFilter { get; set; }
        public string BonusSumFilter { get; set; }

        public virtual RDiscSaleD RDiscSaleD { get; set; }
    }
}
