using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrCstCode
    {
        public long ChId { get; set; }
        public byte CstTypeId { get; set; }
        public string CstProdCode { get; set; }
        public string CstProdName { get; set; }
        public string CstFullProdName { get; set; }
        public string CstProdNameDesc { get; set; }
    }
}
