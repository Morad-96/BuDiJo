namespace BuDiJo.Models
{
    public class EmployeeTask
    {
        public int Employee_ID { get; set; }
        public Employee? Employees { get; set; }

        public int Task_ID { get; set; }
        public Tasks? Tasks { get; set; }
    }
}
