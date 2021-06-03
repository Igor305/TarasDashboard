using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZWcopy
    {
        public int CopyId { get; set; }
        public string CopyName { get; set; }
        public string CopyDesc { get; set; }
        public int SrcDocType { get; set; }
        public int DstDocType { get; set; }
        public bool IsSaved { get; set; }
        public bool IsChange { get; set; }
        public bool IsAutoChange { get; set; }
        public string StartDesc1 { get; set; }
        public string StartDesc2 { get; set; }
        public byte DbsourceMode { get; set; }
        public string DbserverName { get; set; }
        public string DbbaseName { get; set; }
        public string DbuserName { get; set; }
        public bool UseDisableControls { get; set; }
        public bool UseMasterField { get; set; }
        public bool MarkCopyInBkeep { get; set; }
        public bool UpdateStatId { get; set; }
        public string ScBeforeRun { get; set; }
        public string ScAfterRun { get; set; }
        public bool AllowUpdateStateCode { get; set; }
        public int StateCode { get; set; }
        public bool LinkDocs { get; set; }
        public bool SrcDocIsParent { get; set; }
        public bool AllowLinkDocs { get; set; }
        public int RunFrom { get; set; }
        public bool? LinkDocsWithSum { get; set; }
        public int DocLinkTypeId { get; set; }
        public bool SendDoneMsgToForm { get; set; }
    }
}
