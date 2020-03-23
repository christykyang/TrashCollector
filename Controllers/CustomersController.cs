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
    [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        public ApplicationDbContext _context;
        private object context;
        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }
        //public object Customers { get; private set; }
        public IdentityUser IdentityUser { get; private set; }

        // GET: Customer
        public ActionResult Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var customer = _context.Customers.Include(k => k.IdentityUser).Where(c => c.IdentityUserId == userId).Single();

            return View(customer);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(k => k.IdentityUser).SingleOrDefault(c => c.CustomerId == id);
            return View(customer);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
           // var customers = _context.Customers.ToList();
            Customer customer = new Customer();
            {
                IdentityUser = IdentityUser;
            }
            return View(customer);
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            try
            {
                // TODO: Add insert logic here
                //access current sign-in user (identity user)
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                //assign customer FK to identityuser PK
                customer.IdentityUserId = userId;

                //add customer to customers table in DB
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(); 
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            Customer customer = new Customer();
            customer.CustomerId = id;
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Customer customer)
        {
            try
            {
                // TODO: Add update logic here
                Customer newCustomer = _context.Customers.Where(a => a.CustomerId == id).Single();
                newCustomer.FirstName = customer.FirstName;
                newCustomer.LastName = customer.LastName;
                newCustomer.PickUpDay = customer.PickUpDay;
                newCustomer.StreetAddress = customer.StreetAddress;
                newCustomer.City = customer.City;
                newCustomer.State = customer.State;
                newCustomer.Zipcode = customer.Zipcode;
                newCustomer.OneTimePickUp = customer.OneTimePickUp;
                newCustomer.StartSuspension = customer.StartSuspension;
                newCustomer.EndSuspension = customer.EndSuspension;
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //// GET: Customer/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Customer/Delete/5
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