using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VSizeCache
    {
        public string Cache { get; set; }
        public long? CacheSizeMb { get; set; }
        public int? PercentOfTotalQueries { get; set; }
    }
}
