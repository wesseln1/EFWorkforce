using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFWorkForce.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(55, MinimumLength = 2, ErrorMessage = "First Name must be between 2-55 characters")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(55, MinimumLength = 2, ErrorMessage = "Last Name must be between 2-55 characters")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Needs to be a valid email address")]
        public string Email { get; set; }
        [Display(Name = "Is Supervisor")]
        public bool IsSupervisor { get; set; }
        [Display(Name = "Computer Id")]
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
