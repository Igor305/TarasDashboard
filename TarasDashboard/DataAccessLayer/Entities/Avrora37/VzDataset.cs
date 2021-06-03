using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzDataset
    {
        public int DocCatCode { get; set; }
        public int DocGrpCode { get; set; }
        public string DocName { get; set; }
        public int Dscode { get; set; }
        public string Dsname { get; set; }
        public int DocCode { get; set; }
        public int TableCode { get; set; }
        public int PageIndex { get; set; }
        public string PageName { get; set; }
        public int PageStyle { get; set; }
        public bool PageVisible { get; set; }
        public string Sqlstr { get; set; }
        public int Sqltype { get; set; }
        public string IntName { get; set; }
        public string SortFields { get; set; }
        public string IntFilter { get; set; }
        public string OpenFilter { get; set; }
        public bool FilterBeforeOpen { get; set; }
        public bool IsDefault { get; set; }
        public string MasterSource { get; set; }
        public string MasterFields { get; set; }
        public bool ReadOnly { get; set; }
        public short UserCode { get; set; }
        public byte AfcolCount { get; set; }
        public int Dslevel { get; set; }
        public int ColWidth { get; set; }
        public int DescWidth { get; set; }
        public int PageHeight { get; set; }
        public int AfcodeWidth { get; set; }
        public bool OptimizeData { get; set; }
        public string TableName { get; set; }
    }
}
