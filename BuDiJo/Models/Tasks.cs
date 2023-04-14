using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BuDiJo.Models
{
    public class Tasks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Task_ID { get; set; }

        [MaxLength(100)]
        [Display(Name = "Task Name")]
        public string TaskName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }
        
        public DateTime DueDate { get; set; }
        
        [Display(Name = "Raised By")]
        public int RaisedByEmployeeId { get; set; }
        public Employee RaisedByEmployee { get; set; }

        [Display(Name = "Assigned To")]
        public int AssignedToEmployeeId { get; set; }
        public Employee AssignedToEmployee { get; set; }

        [NotMapped]
        public IFormFile Attachments { get; set; }

        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }

        //Relations
        //Employee Task Relation
        public IList<EmployeeTask>? EmployeeTasks { get; set; }

    }
    public enum TaskPriority
    {
        High,
        Medium,
        Low
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}

