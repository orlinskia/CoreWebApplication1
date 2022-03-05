using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CoreWebApplication1.Models
{
    public partial class BaseContext : DbContext
    {
        public BaseContext()
        {
        }

        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Department1> Departments1 { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobHistory> JobHistories { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Tb1> Tb1s { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Filename=db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
