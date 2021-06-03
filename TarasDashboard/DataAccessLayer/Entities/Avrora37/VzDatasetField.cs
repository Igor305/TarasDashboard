using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzDatasetField
    {
        public int DocCatCode { get; set; }
        public int DocGrpCode { get; set; }
        public int DocCode { get; set; }
        public string DocName { get; set; }
        public string Dsname { get; set; }
        public int Dscode { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldInfo { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public bool Visible { get; set; }
        public string DisplayFormat { get; set; }
        public int Width { get; set; }
        public int AutoNewType { get; set; }
        public string AutoNewValue { get; set; }
        public int? DataSize { get; set; }
        public bool Calc { get; set; }
        public bool Lookup { get; set; }
        public string LookupKey { get; set; }
        public string LookupSource { get; set; }
        public string LookupSourceKey { get; set; }
        public string LookupSourceResult { get; set; }
        public int PickListType { get; set; }
        public string PickList { get; set; }
        public string EditMask { get; set; }
        public string EditFormat { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public string CustomConstraint { get; set; }
        public string ErrorMessage { get; set; }
        public bool? InitBeforePost { get; set; }
        public bool IsHidden { get; set; }
        public int TotalsKind { get; set; }
        public int TableCode { get; set; }
        public string TableName { get; set; }
        public string TableDesc { get; set; }
        public bool IsView { get; set; }
        public byte DataType { get; set; }
        public int Sqltype { get; set; }
        public string SqltypeName { get; set; }
        public string FieldDesc { get; set; }
    }
}
