using Core.Entities.Customers;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Employees
{
    public class Employee :BaseEntity
    {
        public int BranchId { get; set; }

        public string Name { get; set; }
        public string EmployeeNo { get; set; }

        public string MachineId { get; set; }
        public decimal Salary { get; set; }

        public Branch Branch { get; set; }
    }
}
