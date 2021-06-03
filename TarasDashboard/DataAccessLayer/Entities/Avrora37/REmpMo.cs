using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class REmpMo
    {
        public int OurId { get; set; }
        public int EmpId { get; set; }
        public bool Official { get; set; }
        public int BankId { get; set; }
        public string CardAcc { get; set; }
        public decimal Csalary { get; set; }
        public decimal BoldSalary { get; set; }
        public bool BoldJoint { get; set; }
        public byte InsurSenYears { get; set; }
        public byte InsurSenMonths { get; set; }
        public short InsurSenDays { get; set; }
        public DateTime? BoldAcceptDate { get; set; }
        public DateTime? BoldDismissDate { get; set; }
        public decimal BoldAlimonyPrc { get; set; }
        public string BoldJobDesc { get; set; }
        public byte BoldPersCat { get; set; }
        public byte? EmpState { get; set; }
        public bool HandCwtime { get; set; }
        public short BoldDepId { get; set; }
        public string IntEmpId { get; set; }
    }
}
