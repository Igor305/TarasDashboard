using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RScale
    {
        public long ChId { get; set; }
        public byte SrvId { get; set; }
        public int ScaleGrId { get; set; }
        public int ScaleId { get; set; }
        public string ScaleName { get; set; }
        public string ScaleInfo { get; set; }
        public int? ScaleType { get; set; }
        public string ScaleSerial { get; set; }
        public string Ip { get; set; }
        public int? NetPort { get; set; }
        public int? ComPort { get; set; }
        public short? BaudRate { get; set; }
        public int MaxProdQty { get; set; }
        public int MaxProdId { get; set; }
        public int ScaleDefId { get; set; }
        public int StockId { get; set; }
    }
}
