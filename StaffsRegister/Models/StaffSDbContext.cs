using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace StaffsRegister.Models
{
    public partial class StaffSDbContext : DbContext
    {
        public StaffSDbContext()
        {
        }

        public StaffSDbContext(DbContextOptions<StaffSDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StaffsRegister> StaffsRegisters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=StaffSDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<StaffsRegister>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StaffsRegister");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.GrossIncome).IsRequired();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.NetIncome).IsRequired();

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.Salary).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
