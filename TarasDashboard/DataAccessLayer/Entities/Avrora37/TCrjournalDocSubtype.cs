using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCrjournalDocSubtype
    {
        public TCrjournalDocSubtype()
        {
            TCrjournals = new HashSet<TCrjournal>();
        }

        public int DocSubtypeId { get; set; }
        public string DocSubtypeName { get; set; }

        public virtual ICollection<TCrjournal> TCrjournals { get; set; }
    }
}
