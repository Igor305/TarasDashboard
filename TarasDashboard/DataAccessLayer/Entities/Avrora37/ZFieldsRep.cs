using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ZFieldsRep
    {
        public ZFieldsRep()
        {
            ZDatasetFields = new HashSet<ZDatasetField>();
            ZFields = new HashSet<ZField>();
            ZReplicaReplaces = new HashSet<ZReplicaReplace>();
            ZToolFields = new HashSet<ZToolField>();
        }

        public int FieldsRepGrpCode { get; set; }
        public string FieldName { get; set; }
        public string FieldDesc { get; set; }
        public string FieldNick { get; set; }
        public string FieldInfo { get; set; }
        public byte DataType { get; set; }
        public int DataSize { get; set; }
        public int Sqltype { get; set; }
        public int? Sqlprec { get; set; }
        public int? Sqlscale { get; set; }
        public short FieldCount { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public bool? Visible { get; set; }
        public string DisplayFormat { get; set; }
        public int Width { get; set; }
        public int AutoNewType { get; set; }
        public string AutoNewValue { get; set; }
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
        public string Dbdefault { get; set; }
        public bool Separator { get; set; }
        public bool HideZeros { get; set; }
        public byte DecimalCount { get; set; }
        public byte FixedCount { get; set; }
        public bool Currency { get; set; }
        public byte Alignment { get; set; }
        public bool InitBeforePost { get; set; }
        public bool IsHidden { get; set; }
        public int TotalsKind { get; set; }
        public int FieldId { get; set; }

        public virtual ZFieldsRepGrp FieldsRepGrpCodeNavigation { get; set; }
        public virtual ICollection<ZDatasetField> ZDatasetFields { get; set; }
        public virtual ICollection<ZField> ZFields { get; set; }
        public virtual ICollection<ZReplicaReplace> ZReplicaReplaces { get; set; }
        public virtual ICollection<ZToolField> ZToolFields { get; set; }
    }
}
