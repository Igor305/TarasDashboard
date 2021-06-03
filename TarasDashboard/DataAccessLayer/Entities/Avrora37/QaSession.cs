using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class QaSession
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? StockId { get; set; }
        public DateTime? DocDate { get; set; }
        public string CameraNumber { get; set; }
        public int? Status { get; set; }
    }
}
