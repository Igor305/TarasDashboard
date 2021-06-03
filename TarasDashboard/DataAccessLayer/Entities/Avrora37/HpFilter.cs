using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class HpFilter
    {
        public int Id { get; set; }
        public string FilterName { get; set; }
        public int? FilterPriority { get; set; }
    }
}
