using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrPersonEmp
    {
        public long ChId { get; set; }
        public DateTime? InstallationDate { get; set; }
        public DateTime? DeinstallationDate { get; set; }
        public int PersonId { get; set; }
        public int EmpId { get; set; }
    }
}
