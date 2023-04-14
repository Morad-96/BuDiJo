using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BuDiJo.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ticket_ID { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [Display(Name = "UID")]
        public int User_UID { get; set; }
        public int PhoneNumber { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        [Display(Name = "Creation Time")]
        public DateTime CreatedTime { get; set; }

        [Display(Name = "Raised By")]
        public int RaisedByEmployeeId { get; set; }
        public Employee RaisedByEmployee { get; set; }

        [Display(Name = "Assigned To")]
        public int AssignedToEmployeeId { get; set; }
        public Employee AssignedToEmployee { get; set; }

        public TicketStatus Status { get; set; }

        //Relations
        public IList<EmployeeTicket>? EmployeeTickets { get; set; }
    }
    public enum TicketStatus
    {
        NotStarted,
        InProgress,
        Completed
    }
}

