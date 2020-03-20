using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Trash.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PickUpDay { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int Balance { get; set; }
        public string OneTimePickUp { get; set; }
        public string StartSupension { get; set; }
        public string EndSuspension { get; set; }
        public bool isSuspended { get; set; }
        [ForeignKey("IdentityUser")]
        public string IdentityUser { get; set; }
        public IdentityUser identityUser { get; set; }
    }
}
