using System;
using Microsoft.EntityFrameworkCore;
using Blazor.Models;

namespace Blazor.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Departments Table
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 2, Name = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 3, Name = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 4, Name = "Admin" });

            // Seed Employee Table
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "J",
                LastName = "H",
                Email = "D@soufiene.com",
                DateOfBrith = new DateTime(1990, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/j.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "S",
                LastName = "G",
                Email = "Sam@soufiene.com",
                DateOfBrith = new DateTime(1991, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2,
                PhotoPath = "images/s.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "M",
                LastName = "E",
                Email = "mary@soufiene.com",
                DateOfBrith = new DateTime(1989, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/o.png"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 4,
                FirstName = "P",
                LastName = "H",
                Email = "ii@soufiene.com",
                DateOfBrith = new DateTime(1995, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/ii.png"
            });
        }
    }
}
