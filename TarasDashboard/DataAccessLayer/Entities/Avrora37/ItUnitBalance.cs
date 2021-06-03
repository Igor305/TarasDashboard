using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItUnitBalance
    {
        public long ChId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? UnDisAllUnit { get; set; }
        public decimal? UnDisOfAllonTt { get; set; }
        public decimal? UnDisNumArt { get; set; }
        public decimal? UnDisNumOrdLine { get; set; }
        public decimal? UnDisSumCcin { get; set; }
        public decimal? ExpRecAllUnit { get; set; }
        public decimal? ExpRecNumArt { get; set; }
        public decimal? ExpRecSumCcin { get; set; }
        public decimal? ActRecAllUnit { get; set; }
        public decimal? ActRecNumArt { get; set; }
        public decimal? ActRecSumCcin { get; set; }
        public decimal? DisAllUnit { get; set; }
        public decimal? DisNumArt { get; set; }
        public decimal? DisSumCcin { get; set; }
        public decimal? ProcAllUnit { get; set; }
        public decimal? ProcOfAllonTt { get; set; }
        public decimal? ProcNumArt { get; set; }
        public decimal? ProcNumOrdLine { get; set; }
        public decimal? ProcSumCcin { get; set; }
        public decimal? ProcSumCcinPerDay { get; set; }
        public decimal? ExcAllUnit { get; set; }
        public decimal? ExcSumCcin { get; set; }
        public decimal? ExcSumCcinNewTt { get; set; }
        public decimal? AvgProcAllUnit { get; set; }
        public decimal? AvgProcAllonTt { get; set; }
        public decimal? AvgProcNumArt { get; set; }
        public decimal? AvgProcNumOrdLine { get; set; }
        public decimal? AvgProcSumCcin { get; set; }
        public decimal? AvgProcSumCcinonTt { get; set; }
    }
}
