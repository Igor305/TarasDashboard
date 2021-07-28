﻿using System;

namespace BusinessLogicLayer.Models
{
    public class SaleStatisticModel
    {
        public DateTime DateOfData { get; set; }
        public string DateOfString { get; set; }
        public decimal TSumCC_wt { get; set; }
        public decimal AvgCheck { get; set; }
        public decimal Rec { get; set; }
        public decimal Margin { get; set; }
        public decimal Turnover { get; set; }
        public decimal? LFL { get; set; }
    }
}
