using Core.Entities.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Payroll
{
    public class SalaryHistory : BaseEntity
    {
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }

        public decimal Amount { get; set; }

        public Employee Employee { get; set; }

    }



}
