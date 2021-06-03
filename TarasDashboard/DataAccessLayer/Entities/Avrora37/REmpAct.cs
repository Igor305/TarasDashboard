using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpAct
    {
        public int EmpId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public string PrvPlEmp { get; set; }
        public string DisReasonText { get; set; }
        public string Notes { get; set; }
    }
}
