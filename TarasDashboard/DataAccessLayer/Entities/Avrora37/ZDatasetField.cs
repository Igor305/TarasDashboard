using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZDatasetField
    {
        public int Dscode { get; set; }
        public int FieldPosId { get; set; }
        public string FieldName { get; set; }
        public string FieldInfo { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public bool? Visible { get; set; }
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
        public int FieldViewType { get; set; }
        public bool UseExtendedEdit { get; set; }

        public virtual ZFieldsRep FieldNameNavigation { get; set; }
    }
}
