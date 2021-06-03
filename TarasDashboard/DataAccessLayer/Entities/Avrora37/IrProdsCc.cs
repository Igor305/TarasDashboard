using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrProdsCc
    {
        public long ChId { get; set; }
        public DateTime? Bdate1 { get; set; }
        public DateTime? Edate1 { get; set; }
        public short? Validity { get; set; }
        public short ChannelId { get; set; }
        public bool? PlId0 { get; set; }
        public bool? PlId1 { get; set; }
        public bool? PlId2 { get; set; }
        public bool? PlId3 { get; set; }
        public bool? PlId4 { get; set; }
        public bool? PlId5 { get; set; }
        public bool? PlId6 { get; set; }
        public bool? PlId7 { get; set; }
        public int Initiator { get; set; }
        public int WempId { get; set; }
        public DateTime DateOfEntry { get; set; }
        public int ProdId { get; set; }
        public DateTime? ComBdate { get; set; }
        public DateTime? ComEdate { get; set; }
        public decimal? CurrentPrice { get; set; }
        public decimal? ComPrice { get; set; }
        public string ComName { get; set; }
        public bool? Enabled { get; set; }
    }
}
