﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VzToolApp
    {
        public int RepToolCode { get; set; }
        public string RepToolName { get; set; }
        public string FormClass { get; set; }
        public int ToolCode { get; set; }
        public string ToolName { get; set; }
        public string ShortCut { get; set; }
        public int TargetDocCode { get; set; }
        public string TargetDocName { get; set; }
        public int SourceAppCode { get; set; }
        public string SourceAppName { get; set; }
    }
}
