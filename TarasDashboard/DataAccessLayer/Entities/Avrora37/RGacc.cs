using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RGacc
    {
        public byte GaccId1 { get; set; }
        public byte GaccId2 { get; set; }
        public short GaccId3 { get; set; }
        public int GaccId { get; set; }
        public string GaccName { get; set; }
        public string Notes { get; set; }
        public bool GaccRollUp { get; set; }
        public byte GaccType { get; set; }
        public bool GaccMain { get; set; }
        public int ACompId { get; set; }
        public int AEmpId { get; set; }
        public short ACodeId1 { get; set; }
        public short ACodeId2 { get; set; }
        public short ACodeId3 { get; set; }
        public short ACodeId4 { get; set; }
        public short ACodeId5 { get; set; }
        public int AStockId { get; set; }
        public int AProdId { get; set; }
        public int AAssId { get; set; }
        public int AVolId { get; set; }
        public byte ACompVol { get; set; }
        public byte AEmpVol { get; set; }
        public byte ACodeVol1 { get; set; }
        public byte ACodeVol2 { get; set; }
        public byte ACodeVol3 { get; set; }
        public byte ACodeVol4 { get; set; }
        public byte ACodeVol5 { get; set; }
        public byte AStockVol { get; set; }
        public byte AProdVol { get; set; }
        public byte AAssVol { get; set; }
        public byte AVolVol { get; set; }
        public bool AIncQty { get; set; }
        public bool AAddQty { get; set; }
    }
}
