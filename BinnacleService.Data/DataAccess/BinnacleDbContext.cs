using System;
using BinnacleService.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BinnacleService.Data.DataAccess
{
    public partial class BinnacleDbContext : DbContext
    {
        public BinnacleDbContext()
        {
        }

        public BinnacleDbContext(DbContextOptions<BinnacleDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Binnacle> Binnacle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PXL201701875\\SQLEXPRESS;Database=BinnacleDataBase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Binnacle>(entity =>
            {
                entity.Property(e => e.BinnacleId).HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.DateBinnacle).HasColumnType("date");

                entity.Property(e => e.Details).HasMaxLength(100);
            });
        }
    }
}
