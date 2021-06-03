using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdImage
    {
        public int ProdId { get; set; }
        public int SrcPosId { get; set; }
        public string FilePath { get; set; }
        public int ImageType { get; set; }
        public bool IsMain { get; set; }
        public byte[] Picture { get; set; }
    }
}
