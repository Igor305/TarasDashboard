using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RPostMc
    {
        public int PostId { get; set; }
        public byte EmpClass { get; set; }
        public string ClassName { get; set; }
        public decimal ClassFactor { get; set; }
        public decimal ClassSalary { get; set; }
    }
}
