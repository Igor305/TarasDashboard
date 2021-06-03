using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class IrGoodsSpecification
    {
        public int ProdId { get; set; }
        public string BarCode { get; set; }
        public byte PalletType { get; set; }
        public decimal PalletHeight { get; set; }
        public decimal PalletAllQty { get; set; }
        public decimal PalletGrossWeight { get; set; }
        public decimal PalletNetWeight { get; set; }
        public decimal BoxQtyOnPallet { get; set; }
        public decimal BoxRowsOnpallet { get; set; }
        public decimal BoxQtyOnRow { get; set; }
        public decimal BoxLayerLength { get; set; }
        public decimal BoxLayerWidth { get; set; }
        public decimal BoxWeight { get; set; }
        public decimal BoxLength { get; set; }
        public decimal BoxWidth { get; set; }
        public decimal BoxHeight { get; set; }
        public decimal UnitQtyInbox { get; set; }
        public decimal UnitQtyInsubBox { get; set; }
        public decimal SubBoxWeight { get; set; }
        public decimal SubBoxLength { get; set; }
        public decimal SubBoxWidth { get; set; }
        public decimal SubBoxHeight { get; set; }
        public decimal UnitHeight { get; set; }
        public decimal UnitLength { get; set; }
        public decimal UnitWidth { get; set; }
        public decimal UnitGrossWeight { get; set; }
        public decimal UnitNetWeight { get; set; }
        public decimal Palletlength { get; set; }
        public decimal Palletwidth { get; set; }
        public decimal Layerweight { get; set; }
        public decimal SubboxQtyInBox { get; set; }
    }
}
