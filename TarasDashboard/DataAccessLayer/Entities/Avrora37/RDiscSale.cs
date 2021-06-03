using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RDiscSale
    {
        public RDiscSale()
        {
            RDiscSaleBonus = new HashSet<RDiscSaleBonu>();
        }

        public int DiscCode { get; set; }
        public int SrcPosId { get; set; }
        public string LfilterExp { get; set; }
        public string EfilterExp { get; set; }
        public string LdiscountExp { get; set; }
        public string EdiscountExp { get; set; }
        public string LmaxDiscountExp { get; set; }
        public string EmaxDiscountExp { get; set; }
        public string LminDiscountExp { get; set; }
        public string EminDiscountExp { get; set; }
        public string LmaxSumBonusExp { get; set; }
        public string EmaxSumBonusExp { get; set; }
        public string LminSumBonusExp { get; set; }
        public string EminSumBonusExp { get; set; }
        public string PprodFilter { get; set; }
        public string PcatFilter { get; set; }
        public string PgrFilter { get; set; }
        public string Pgr1Filter { get; set; }
        public string Pgr2Filter { get; set; }
        public string Pgr3Filter { get; set; }
        public bool AllowZeroSumBonus { get; set; }

        public virtual RDisc DiscCodeNavigation { get; set; }
        public virtual ICollection<RDiscSaleBonu> RDiscSaleBonus { get; set; }
    }
}
