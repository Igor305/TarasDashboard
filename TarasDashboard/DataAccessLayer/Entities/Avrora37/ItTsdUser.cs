using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItTsdUser
    {
        public int IdUser { get; set; }
        public string UserRights { get; set; }
        public string UserName { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }
    }
}
