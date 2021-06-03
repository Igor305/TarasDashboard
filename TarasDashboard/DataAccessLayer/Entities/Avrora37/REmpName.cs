using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpName
    {
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public DateTime ChDate { get; set; }
        public string EmpName { get; set; }
        public string EmpInitials { get; set; }
        public string EmpLastName { get; set; }
        public string EmpFirstName { get; set; }
        public string EmpParName { get; set; }
        public string UaempName { get; set; }
        public string UaempLastName { get; set; }
        public string UaempFirstName { get; set; }
        public string UaempParName { get; set; }
        public string UaempInitials { get; set; }
        public string PassSer { get; set; }
        public string PassNo { get; set; }
        public DateTime? PassDate { get; set; }
        public string PassDept { get; set; }
        public string TaxCode { get; set; }
        public string Notes { get; set; }
    }
}
