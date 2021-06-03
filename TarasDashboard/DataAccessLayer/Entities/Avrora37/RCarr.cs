using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RCarr
    {
        public long ChId { get; set; }
        public short CarrId { get; set; }
        public string CarrName { get; set; }
        public string Notes { get; set; }
        public int AssId { get; set; }
        public string StateRegNo { get; set; }
        public string GarageNo { get; set; }
        public string CarMark { get; set; }
        public string CarModel { get; set; }
        public int ProdId { get; set; }
        public decimal ExpNorm { get; set; }
        public short CarrCid { get; set; }
        public string MotorNo { get; set; }
        public string BodyNo { get; set; }
        public string TechnNo { get; set; }
        public decimal TechnMass { get; set; }
        public decimal Tonnage { get; set; }
    }
}
