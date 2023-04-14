namespace BuDiJo.Models
{
    public class EmployeeTicket
    {
        public int Employee_ID { get; set; }
        public Employee? Employees { get; set; }

        public int Ticket_ID { get; set; }
        public Ticket? Tickets { get; set; }
    }
}
