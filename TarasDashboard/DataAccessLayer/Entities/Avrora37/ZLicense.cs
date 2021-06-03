using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZLicense
    {
        public long ChId { get; set; }
        public int LicType { get; set; }
        public byte[] BlobValue { get; set; }
    }
}
