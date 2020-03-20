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
                    Zipcode = 16,
                }); 
            builder.Entity<Employee>().HasData(
                 new Employee
                 {
                     EmployeeId = 2,
                     FirstName = "KN",
                     LastName = "B",
                     Zipcode = 2,
                 });
            builder.Entity<Customer>().HasData(
                 new Customer
                 {
                     CustomerId = 1,
                     FirstName = "Neko",
                     LastName = "Yang",
                     PickUpDay = "Monday",
                     StreetAddress = "123 1st Street",
                     City = "Puppy Town",
                     State = "Dog World",
                     Zipcode = 2,
                     Balance = 0,
                     OneTimePickUp = 11,
                     StartSupension = 0,
                     EndSuspension = 0,
                     isSuspended = false,
                 });
            builder.Entity<Customer>().HasData(
                 new Customer
                 {
                     CustomerId = 2,
                     FirstName = "Nel",
                     LastName = "Yang",
                     PickUpDay = "Wednesday",
                     StreetAddress = "456 2nd Street",
                     City = "Puppy Town",
                     State = "Dog World",
                     Zipcode = 16,
                     Balance = 0,
                     OneTimePickUp = 5,
                     StartSupension = 0,
                     EndSuspension = 0,
                     isSuspended = false,
                 });
            builder.Entity<Customer>().HasData(
                 new Customer
                 {
                     CustomerId = 3,
                     FirstName = "Nyx",
                     LastName = "Yang",
                     PickUpDay = "Friday",
                     StreetAddress = "789 3rd Street",
                     City = "Puppy Town",
                     State = "Dog World",
                     Zipcode = 16,
                     Balance = 0,
                     OneTimePickUp = 1,
                     StartSupension = 0,
                     EndSuspension = 0,
                     isSuspended = false,
                 });

        }
        public DbSet<Trash.Models.Employee> Employees { get; set; }
        public DbSet<Trash.Models.Customer> Customers { get; set; }
        public object Employee { get; internal set; }
        public object Customer { get; internal set; }
    }
}
