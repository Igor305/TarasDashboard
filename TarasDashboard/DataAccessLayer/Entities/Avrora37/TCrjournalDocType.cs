using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TCrjournalDocType
    {
        public TCrjournalDocType()
        {
            TCrjournals = new HashSet<TCrjournal>();
        }

        public int DocTypeId { get; set; }
        public string DocTypeName { get; set; }

        public virtual ICollection<TCrjournal> TCrjournals { get; set; }
    }
}
