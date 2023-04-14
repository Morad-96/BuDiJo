using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BuDiJo.Models
{
    [Index(nameof(Department_Name), IsUnique = true)]
    public class Department
    {
        [Key]
        public int Department_ID { get; set; }

        [Required(ErrorMessage = "Please Enter Department Name")]
        [Display(Name = "Department Name")]
        [MaxLength(100)]
        public string Department_Name { get; set; }

    }
}
