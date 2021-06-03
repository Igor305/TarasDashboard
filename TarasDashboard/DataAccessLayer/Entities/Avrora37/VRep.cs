using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer
{
    public partial class VRep
    {
        public VRep()
        {
            VDatabases = new HashSet<VDatabase>();
            VFields = new HashSet<VField>();
            VGraphs = new HashSet<VGraph>();
            VNotifies = new HashSet<VNotify>();
            VParams = new HashSet<VParam>();
            VRepUsers = new HashSet<VRepUser>();
            VSourceGrs = new HashSet<VSourceGr>();
            VSources = new HashSet<VSource>();
            VUfields = new HashSet<VUfield>();
            VUgraphs = new HashSet<VUgraph>();
            VUnotifies = new HashSet<VUnotify>();
            VUparams = new HashSet<VUparam>();
            VUreps = new HashSet<VUrep>();
            VUscripts = new HashSet<VUscript>();
            VUviews = new HashSet<VUview>();
            VViews = new HashSet<VView>();
        }

        public int RepId { get; set; }
        public string RepName { get; set; }
        public string RepInfo { get; set; }
        public string Creator { get; set; }
        public DateTime Created { get; set; }
        public string Changer { get; set; }
        public DateTime? Changed { get; set; }
        public short RepGrId { get; set; }
        public DateTime? Bdate { get; set; }
        public DateTime? Edate { get; set; }
        public int? DataWidth { get; set; }
        public int? RowHeight { get; set; }
        public byte Processors { get; set; }
        public string DateField { get; set; }
        public bool GrandCols { get; set; }
        public bool GrandRows { get; set; }
        public bool AlwaysPrepare { get; set; }
        public int? Optimization { get; set; }
        public bool TempTable { get; set; }
        public bool FilterOnOpen { get; set; }
        public bool? FilterOnPrepare { get; set; }
        public bool IsReady { get; set; }
        public string RepNotes { get; set; }
        public bool RepNotesOpen { get; set; }
        public bool RepNotesEdit { get; set; }
        public bool SendError { get; set; }
        public bool FilterValid { get; set; }
        public string PrintFontName { get; set; }
        public int PrintFontSize { get; set; }
        public bool? PrintLandscape { get; set; }
        public string ObjectDef { get; set; }

        public virtual VRepGr RepGr { get; set; }
        public virtual VScript VScript { get; set; }
        public virtual ICollection<VDatabase> VDatabases { get; set; }
        public virtual ICollection<VField> VFields { get; set; }
        public virtual ICollection<VGraph> VGraphs { get; set; }
        public virtual ICollection<VNotify> VNotifies { get; set; }
        public virtual ICollection<VParam> VParams { get; set; }
        public virtual ICollection<VRepUser> VRepUsers { get; set; }
        public virtual ICollection<VSourceGr> VSourceGrs { get; set; }
        public virtual ICollection<VSource> VSources { get; set; }
        public virtual ICollection<VUfield> VUfields { get; set; }
        public virtual ICollection<VUgraph> VUgraphs { get; set; }
        public virtual ICollection<VUnotify> VUnotifies { get; set; }
        public virtual ICollection<VUparam> VUparams { get; set; }
        public virtual ICollection<VUrep> VUreps { get; set; }
        public virtual ICollection<VUscript> VUscripts { get; set; }
        public virtual ICollection<VUview> VUviews { get; set; }
        public virtual ICollection<VView> VViews { get; set; }
    }
}
