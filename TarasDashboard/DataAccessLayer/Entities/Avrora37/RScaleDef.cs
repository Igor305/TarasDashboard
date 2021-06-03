using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RScaleDef
    {
        public long ChId { get; set; }
        public int ScaleDefId { get; set; }
        public string ScaleDefName { get; set; }
        public int ScaleType { get; set; }
        public int ScaleImageNum { get; set; }
        public bool ScaleImageType { get; set; }
        public string ScaleImage { get; set; }
        public string Notes { get; set; }
    }
}
