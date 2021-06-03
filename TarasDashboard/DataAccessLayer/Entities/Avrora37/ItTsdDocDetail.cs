using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItTsdDocDetail
    {
        public int IdDoc { get; set; }
        public int IdGood { get; set; }
        public double? CountDoc { get; set; }
        public double? CountReal { get; set; }
    }
}
