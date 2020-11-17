using System;

namespace Core.Entities.Employees
{
    public class Attendance : BaseEntity
    {
        public int EmployeeId { get; set; }
        public int InOrOut { get; set; }

        public DateTime Time { get; set; }

        public Employee Employee { get; set; }
    }
}
