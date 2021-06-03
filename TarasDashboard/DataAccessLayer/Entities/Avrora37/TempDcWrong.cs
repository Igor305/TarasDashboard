using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class TempDcWrong
    {
        public int LogId { get; set; }
        public DateTime DocDate { get; set; }
        public string Notes { get; set; }
        public string ClientName { get; set; }
        public DateTime? BirthDay { get; set; }
        public short Sex { get; set; }
        public string PhoneMob { get; set; }
        public int Status { get; set; }
        public string ErrorMessage { get; set; }
        public string DcardIdold { get; set; }
        public long DcardChId { get; set; }
        public string DcardId { get; set; }
    }
}
