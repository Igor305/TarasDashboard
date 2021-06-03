using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCompsAdd
    {
        public int CompId { get; set; }
        public string CompAdd { get; set; }
        public string CompAddDesc { get; set; }
        public bool CompDefaultAdd { get; set; }
    }
}
