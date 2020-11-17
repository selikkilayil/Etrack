using Core.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Payroll
{
    public class SalaryProcess : BaseEntity
    {
        public int EmployeeId { get; set; }

        public decimal WorkUnit { get; set; }

        public decimal Salary { get; set; }

        public DateTime Date { get; set; }

        public bool Accepted { get; set; }


        public Employee Employee { get; set; }

    }
}
