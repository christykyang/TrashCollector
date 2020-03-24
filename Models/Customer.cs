using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Trash.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Pick Up Day")]
        public string PickUpDay { get; set; }
        [Display(Name = "Address")]
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        [Display(Name = "Account Balance")]
        public int Balance { get; set; }
        [Display(Name = "One Time Pick-Up Date")]
        public string OneTimePickUp { get; set; }
        [Display(Name = "Start of Suspension Date")]
        public string StartSuspension { get; set; }
        [Display(Name = "End of Suspension Date")]
        public string EndSuspension { get; set; }
        [Display(Name = "Account Suspended")]
        public bool isSuspended { get; set; }
        [ForeignKey("IdentityUser")]
        [Display(Name = "User Type")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        public IEnumerable<Customer> Customers { get; set; }
    }
}
