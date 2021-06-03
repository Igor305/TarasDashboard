using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class BGview
    {
        public int DocCode { get; set; }
        public int ViewId { get; set; }
        public string ViewName { get; set; }
        public bool Dtrans { get; set; }
        public bool Ctrans { get; set; }
        public bool Standard { get; set; }
        public bool CboxState1 { get; set; }
        public bool CboxState2 { get; set; }
        public bool CboxState3 { get; set; }
        public bool CboxState4 { get; set; }
        public bool CboxState5 { get; set; }
        public bool CboxState6 { get; set; }
        public bool CboxState7 { get; set; }
        public byte AboxState1 { get; set; }
        public byte AboxState2 { get; set; }
        public byte AboxState3 { get; set; }
        public string OurList { get; set; }
        public string DGaccs { get; set; }
        public string CGaccs { get; set; }
        public bool DGaccUse { get; set; }
        public bool CGaccUse { get; set; }
    }
}
