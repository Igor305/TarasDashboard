using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class QaAchievement
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? Result { get; set; }
        public string Type { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
