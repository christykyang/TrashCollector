using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trash.Models;

namespace Trash.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                });
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                });
            builder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "CK",
                    LastName = "Y",
                    Zipcode = 53227,
                }); 
            builder.Entity<Employee>().HasData(
                 new Employee
                 {
                     EmployeeId = 2,
                     FirstName = "KN",
                     LastName = "B",
                     Zipcode = 53213,
                 });

        }
        public DbSet<Trash.Models.Employee> Employees { get; set; }
        public DbSet<Trash.Models.Customer> Customers { get; set; }
        public object Employee { get; internal set; }
        public object Customer { get; internal set; }
    }
}
