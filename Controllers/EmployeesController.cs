using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        //public object Customers { get; private set; }
        // GET: Employees
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employeeLoggedIn = _context.Employees.Where(e => e.IdentityUserId == userId).Single();
            
            var customers = _context.Customers.Include(k => k.IdentityUser).Where(c => c.Zipcode == employeeLoggedIn.Zipcode).ToList();
            //query customers variable by day of week (compare to today's day of week)
            return View(customers);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {            var customer = _context.Customers.Include(k => k.IdentityUser).SingleOrDefault(c => c.CustomerId == id);
            return View();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}