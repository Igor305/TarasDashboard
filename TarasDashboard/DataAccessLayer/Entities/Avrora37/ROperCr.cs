using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class ROperCr
    {
        public short Crid { get; set; }
        public int OperId { get; set; }
        public byte CroperId { get; set; }
        public decimal OperMaxQty { get; set; }
        public bool? CanEditDiscount { get; set; }
        public bool Crvisible { get; set; }
        public int OperPwd { get; set; }
        public bool? AllowChequeClose { get; set; }
        public bool? AllowAddToChequeFromCat { get; set; }
        public bool Cradmin { get; set; }
        public bool AllowChangeDctype { get; set; }
    }
}
