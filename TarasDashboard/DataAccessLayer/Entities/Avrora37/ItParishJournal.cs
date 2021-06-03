using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ItParishJournal
    {
        public long ChId { get; set; }
        public long DocId { get; set; }
        public DateTime DocDate { get; set; }
        public DateTime? SrcDocdate { get; set; }
        public int CompId { get; set; }
        public int CompGrId3 { get; set; }
        public short CodeId5 { get; set; }
        public string CarNumber { get; set; }
        public byte? PalUnloading { get; set; }
        public short? Pallets { get; set; }
        public decimal? Weight1 { get; set; }
        public short? QtyPlaces { get; set; }
        public DateTime? StartUnloading { get; set; }
        public DateTime? EndUnloading { get; set; }
        public byte? QtyPeopleUn { get; set; }
        public short? DifUnloading { get; set; }
        public DateTime? StartReception { get; set; }
        public DateTime? EndReception { get; set; }
        public byte? QtyPeopleRec { get; set; }
        public short? DifReception { get; set; }
        public string Cell { get; set; }
        public int? AcceptedId { get; set; }
        public decimal? Space1 { get; set; }
        public decimal? QtyPositions { get; set; }
        public string PassedName { get; set; }
        public byte? ViolId { get; set; }
        public short CodeId4 { get; set; }
        public string ContainerNumber { get; set; }
        public int? StockId { get; set; }
        public int Spell { get; set; }
    }
}
