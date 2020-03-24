using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Trash.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }
        [ForeignKey("IdentityUser")]
        [Display(Name = "IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser identityUser { get; set; }
        
        //public IEnumerable<Employee> Employees { get; set; }
    }
}
