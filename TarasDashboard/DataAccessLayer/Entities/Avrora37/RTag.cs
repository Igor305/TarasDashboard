using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RTag
    {
        public long ChId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int TagCid { get; set; }
        public string Notes { get; set; }
    }
}
