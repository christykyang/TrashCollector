using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trash.Data;
using Trash.Models;

namespace Trash.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        public ApplicationDbContext _context;
        private object context; 
        public static DateTime Now { get; }
        public IdentityUser IdentityUser { get; private set; }

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Employees
        public ActionResult Index()
        {
            
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employeeLoggedIn = _context.Employees.Where(e => e.IdentityUserId == userId).Single();
            
            var customersMatchingZip = _context.Customers.Include(k => k.IdentityUser).Where(c => c.Zipcode == employeeLoggedIn.Zipcode).ToList();

            //query customers variable by day of week (compare to today's day of week)
            DateTime dt = DateTime.Now;
            string day = dt.DayOfWeek.ToString();
            //DateTime.Now
            var customerPickUpDay = customersMatchingZip.Where(d => d.PickUpDay == day).ToList();
            var customers = customerPickUpDay.Where(i => i.isSuspended = false).ToList();

            return View(customers);
        }

        public ActionResult FilterByDayOfWeek(string day)
        {
            //pass back a string value from View to Controller method
            if (!String.IsNullOrEmpty(day))
            {
                var customers = _context.Customers.Where(c => c.PickUpDay.Contains(day));
            }

            return View("Index", "Customers");
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {            
            var customer = _context.Customers.Include(k => k.IdentityUser).SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            Employee employee = new Employee();
            {
                IdentityUser = IdentityUser;
            }
            return View(employee);
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                //assign customer FK to identityuser PK
                employee.IdentityUserId = userId;

                //add customer to customers table in DB
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = new Customer();
            customer.CustomerId = id;
            return View(customer);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                //UPDATE Customer Balance??
                int chargeForPickUp = 50;
                // TODO: Add update logic here
                Customer newCustomer = _context.Customers.Where(a => a.CustomerId == id).Single();
                newCustomer.Balance = customer.Balance + chargeForPickUp;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Employees/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}