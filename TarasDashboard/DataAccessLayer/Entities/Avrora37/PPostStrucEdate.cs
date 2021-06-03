using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class PPostStrucEdate
    {
        public int ChId { get; set; }
        public DateTime? Edate { get; set; }
        public int OurId { get; set; }
        public string OurName { get; set; }
        public short SubId { get; set; }
        public string SubName { get; set; }
        public int PostId { get; set; }
        public string PostName { get; set; }
        public int StrucPostId { get; set; }
    }
}
