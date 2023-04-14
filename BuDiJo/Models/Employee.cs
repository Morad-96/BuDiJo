using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;

namespace BuDiJo.Models
{
    [Index(nameof(Username), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        [Display(Name = "First Name")]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [Display(Name = "Last Name")]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Hire Date")]
        public DateTime HireDate { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        [MaxLength(100)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords dont match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Enter Phone Number")]
        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        public bool IsManager { get; set; }

        public int? ManagerId { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        //Relations
        public IList<EmployeeTicket>? EmployeeTickets { get; set; }

        public IList<EmployeeTask>? EmployeeTasks { get; set; }

        [ForeignKey("Department_ID")]
        public Department? Departments { get; set; }
    }
}
