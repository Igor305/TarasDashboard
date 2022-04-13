using DataAccessLayer.Entities.Avrora;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DataAccessLayer.AppContext
{
    public partial class AvroraContext : DbContext
    {
        public AvroraContext()
        {
        }

        public AvroraContext(DbContextOptions<AvroraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<IndicatorsByNumberOfStore> IndicatorsByNumberOfStores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=sql03;Initial Catalog=Avrora;Persist Security Info=True;User ID=j-PlanShops-Reader;Password=AE97rX3j5n");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("j-PlanShops-Reader")
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<IndicatorsByNumberOfStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IndicatorsByNumberOfStores", "dashboard");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");
            });
           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
