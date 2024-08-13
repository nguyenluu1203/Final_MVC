using System;
using Microsoft.EntityFrameworkCore;

namespace Final_MVC.Entities
{
    // ApplicationDbContext.cs
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().ToTable("Department_Tbl");
            modelBuilder.Entity<Employee>().ToTable("Employee_Tbl");

            // Configure relationships, keys, etc. here
        }
    }

}

