using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuDiJo.Models
{
    public class ClockEvent
    {
        [Key]
        public int Clock_ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public ClockEventType Type { get; set; }

        // One-to-Many: ClockEvent to Employee (ClockIn)
        [ForeignKey("Employee_ID")]
        public Employee? Employees { get; set; }
    }
    public enum ClockEventType
    {
        ClockIn,
        ClockOut
    }
}
