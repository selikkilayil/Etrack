namespace Core.Entities.Employees
{
    public class AddedAttendance :BaseEntity
    {
        public int EmployeeId { get; set; }
        public int Unit { get; set; }

        public Employee Employee { get; set; }
    }
}
