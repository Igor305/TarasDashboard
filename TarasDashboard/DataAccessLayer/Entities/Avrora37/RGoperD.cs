using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RGoperD
    {
        public int GoperId { get; set; }
        public int SrcPosId { get; set; }
        public string Eexp { get; set; }
        public string Lexp { get; set; }
        public string EexpQty { get; set; }
        public string LexpQty { get; set; }
        public string DGaccRexp { get; set; }
        public string DGaccEexp { get; set; }
        public string CGaccRexp { get; set; }
        public string CGaccEexp { get; set; }
        public string Notes { get; set; }
        public bool InCc { get; set; }
        public bool DIncQty { get; set; }
        public bool DAddQty { get; set; }
        public bool CIncQty { get; set; }
        public bool CAddQty { get; set; }
        public int DCompId { get; set; }
        public int DEmpId { get; set; }
        public short DCodeId1 { get; set; }
        public short DCodeId2 { get; set; }
        public short DCodeId3 { get; set; }
        public short DCodeId4 { get; set; }
        public short DCodeId5 { get; set; }
        public int DStockId { get; set; }
        public int DProdId { get; set; }
        public int DAssId { get; set; }
        public int DVolId { get; set; }
        public int CCompId { get; set; }
        public int CEmpId { get; set; }
        public short CCodeId1 { get; set; }
        public short CCodeId2 { get; set; }
        public short CCodeId3 { get; set; }
        public short CCodeId4 { get; set; }
        public short CCodeId5 { get; set; }
        public int CStockId { get; set; }
        public int CProdId { get; set; }
        public int CAssId { get; set; }
        public int CVolId { get; set; }
        public byte DCompVol { get; set; }
        public byte DEmpVol { get; set; }
        public byte DCodeVol1 { get; set; }
        public byte DCodeVol2 { get; set; }
        public byte DCodeVol3 { get; set; }
        public byte DCodeVol4 { get; set; }
        public byte DCodeVol5 { get; set; }
        public byte DStockVol { get; set; }
        public byte DProdVol { get; set; }
        public byte DAssVol { get; set; }
        public byte DVolVol { get; set; }
        public byte CCompVol { get; set; }
        public byte CEmpVol { get; set; }
        public byte CCodeVol1 { get; set; }
        public byte CCodeVol2 { get; set; }
        public byte CCodeVol3 { get; set; }
        public byte CCodeVol4 { get; set; }
        public byte CCodeVol5 { get; set; }
        public byte CStockVol { get; set; }
        public byte CProdVol { get; set; }
        public byte CAssVol { get; set; }
        public byte CVolVol { get; set; }
        public bool ConductQty { get; set; }
        public int DGrndLinkId { get; set; }
        public int CGrndLinkId { get; set; }
    }
}
