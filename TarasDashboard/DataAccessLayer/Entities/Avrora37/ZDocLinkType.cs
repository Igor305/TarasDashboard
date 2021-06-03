using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDocLinkType
    {
        public int DocLinkTypeId { get; set; }
        public string DocLinkTypeName { get; set; }
        public string Notes { get; set; }
        public int? SignType { get; set; }
    }
}
