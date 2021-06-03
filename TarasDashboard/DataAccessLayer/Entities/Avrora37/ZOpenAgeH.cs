using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZOpenAgeH
    {
        public int OurId { get; set; }
        public DateTime Bdate { get; set; }
        public DateTime Edate { get; set; }
        public byte OpenAgeBtype { get; set; }
        public byte OpenAgeEtype { get; set; }
        public short OpenAgeBqty { get; set; }
        public short OpenAgeEqty { get; set; }
        public short ChUserId { get; set; }
        public DateTime ChDate { get; set; }
        public int StockId { get; set; }
    }
}
