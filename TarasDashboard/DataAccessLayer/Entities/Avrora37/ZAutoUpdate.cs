using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZAutoUpdate
    {
        public ZAutoUpdate()
        {
            ZAufields = new HashSet<ZAufield>();
            ZAutables = new HashSet<ZAutable>();
        }

        public int DocCode { get; set; }
        public int TableCode { get; set; }
        public int Auid { get; set; }
        public string Auname { get; set; }
        public int AutableCode { get; set; }
        public int? AugroupCode { get; set; }
        public int Status { get; set; }
        public bool MinusFirst { get; set; }
        public int Auoperation { get; set; }

        public virtual ZAugroup AugroupCodeNavigation { get; set; }
        public virtual ZDoc DocCodeNavigation { get; set; }
        public virtual ICollection<ZAufield> ZAufields { get; set; }
        public virtual ICollection<ZAutable> ZAutables { get; set; }
    }
}
