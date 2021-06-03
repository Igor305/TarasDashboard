using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpAdd
    {
        public int EmpId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public string RegRegion { get; set; }
        public string RegDistrict { get; set; }
        public string RegCity { get; set; }
        public string RegStreet { get; set; }
        public string RegHouse { get; set; }
        public string RegBlock { get; set; }
        public string RegAptNo { get; set; }
        public string RegPostIndex { get; set; }
        public string FactRegion { get; set; }
        public string FactDistrict { get; set; }
        public string FactCity { get; set; }
        public string FactStreet { get; set; }
        public string FactHouse { get; set; }
        public string FactBlock { get; set; }
        public string FactAptNo { get; set; }
        public string FactPostIndex { get; set; }
    }
}
