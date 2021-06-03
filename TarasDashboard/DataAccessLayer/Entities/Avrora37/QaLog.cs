using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class QaLog
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public string Stock { get; set; }
        public DateTime? Date { get; set; }
        public string Start { get; set; }
        public string Time { get; set; }
        public decimal? TotalQty { get; set; }
        public DateTime? DocDate { get; set; }
        public string CameraNumber { get; set; }
    }
}
