using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RProdCv
    {
        public int ProdId { get; set; }
        public int CompId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public decimal Value1 { get; set; }
        public string Note1 { get; set; }
        public decimal Value2 { get; set; }
        public string Note2 { get; set; }
        public decimal Value3 { get; set; }
        public string Note3 { get; set; }
    }
}
