using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RUni
    {
        public int RefTypeId { get; set; }
        public int RefId { get; set; }
        public string RefName { get; set; }
        public string Notes { get; set; }
        public bool? Relevance { get; set; }
    }
}
