using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrShopsBeforeJob
    {
        public long ChId { get; set; }
        public int DbiId { get; set; }
        public int StockId { get; set; }
        public int Pccode { get; set; }
        public string Notes { get; set; }
        public string TeamViewer1 { get; set; }
        public string TeamViewer2 { get; set; }
        public string TeamViewer3 { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string DbVersion { get; set; }
        public DateTime? LinkedUpdated { get; set; }
        public int LinkedVersion { get; set; }
        public decimal? GeoX { get; set; }
        public decimal? GeoY { get; set; }
        public int? GeoDistance { get; set; }
        public string GeoDistanceMsg { get; set; }
        public string ServerName { get; set; }
        public bool? IsWork { get; set; }
        public string Host { get; set; }
        public string HostName { get; set; }
        public string NearbyStocks { get; set; }
        public string BarcodeRec { get; set; }
        public string BarcodeExp { get; set; }
        public string FilePath { get; set; }
    }
}
