﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class RegionDistrictView
    {
        public int RegionId { get; set; }
        public string DistrictName { get; set; }
        public int LanguageId { get; set; }
    }
}
