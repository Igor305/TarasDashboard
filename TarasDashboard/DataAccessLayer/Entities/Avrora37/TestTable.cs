using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TestTable
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? Price { get; set; }
    }
}
