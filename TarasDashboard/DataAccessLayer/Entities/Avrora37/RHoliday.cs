using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RHoliday
    {
        public long ChId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string HolidayName { get; set; }
        public bool DecWtime { get; set; }
        public string Notes { get; set; }
        public bool IsHoliday { get; set; }
    }
}
