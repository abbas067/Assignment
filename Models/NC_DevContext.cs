using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Assignment.Models
{
    public partial class NC_DevContext : DbContext
    {
       

        public NC_DevContext(DbContextOptions<NC_DevContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAdhaarDetail> TblAdhaarDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ncdevserver.database.windows.net;Initial Catalog=NC_Dev;User ID=abbas067;Password=Abbaskhan.92");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAdhaarDetail>(entity =>
            {
                entity.ToTable("tbl_Adhaar_Details");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AdhaarBackImage).HasMaxLength(50);

                entity.Property(e => e.AdhaarFrontImage).HasMaxLength(50);

                entity.Property(e => e.AdhaarNumber).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("DOB");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PanDocument).HasMaxLength(50);

                entity.Property(e => e.PanNumber).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
