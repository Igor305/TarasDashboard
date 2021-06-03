using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCr
    {
        public long ChId { get; set; }
        public short Crid { get; set; }
        public string Crname { get; set; }
        public string Notes { get; set; }
        public string FinId { get; set; }
        public string FacId { get; set; }
        public byte Crport { get; set; }
        public byte Crcode { get; set; }
        public byte SrvId { get; set; }
        public int StockId { get; set; }
        public int SecId { get; set; }
        public short CashType { get; set; }
        public bool UseProdNotes { get; set; }
        public short BaudRate { get; set; }
        public byte Ledtype { get; set; }
        public bool CanEditPrice { get; set; }
        public bool PaperWarning { get; set; }
        public bool DecQtyFromRef { get; set; }
        public bool UseStockPl { get; set; }
        public int CashRegMode { get; set; }
        public int NetPort { get; set; }
        public string ModemId { get; set; }
        public int ModemPassword { get; set; }
        public string Ip { get; set; }
        public bool? GroupProds { get; set; }
        public bool AutoUpdateTaxes { get; set; }
        public bool BackupCrjournalAfterZreport { get; set; }
        public byte BackupCrjournalAfterChequeType { get; set; }
        public int BackupCrjournalChequeTimeout { get; set; }
        public bool BackupCrjournalInTime { get; set; }
        public DateTime BackupCrjournalExecTime { get; set; }
    }
}
