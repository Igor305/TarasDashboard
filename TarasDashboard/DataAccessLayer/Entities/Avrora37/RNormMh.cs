using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RNormMh
    {
        public short YearId { get; set; }
        public short MonthId { get; set; }
        public byte WweekTypeId { get; set; }
        public decimal? DaysNorm { get; set; }
        public decimal? HoursNorm { get; set; }
    }
}
