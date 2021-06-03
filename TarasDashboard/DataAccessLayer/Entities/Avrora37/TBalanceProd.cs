using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TBalanceProd
    {
        public DateTime Docdate { get; set; }
        public string Tabledesc { get; set; }
        public string Tablename { get; set; }
        public int Ourid { get; set; }
        public int Stockid { get; set; }
        public int Chid { get; set; }
        public int Srcposid { get; set; }
        public int Prodid { get; set; }
        public int Ppid { get; set; }
        public decimal Qty { get; set; }
        public string ToFtran { get; set; }
    }
}
