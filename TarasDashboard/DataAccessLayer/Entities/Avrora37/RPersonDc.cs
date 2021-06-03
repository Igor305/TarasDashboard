using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPersonDc
    {
        public int PersonId { get; set; }
        public string Notes { get; set; }
        public long DcardChId { get; set; }

        public virtual RDcard DcardCh { get; set; }
    }
}
