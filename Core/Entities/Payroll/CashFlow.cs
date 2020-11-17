using Core.Entities.Employees;
using System;

namespace Core.Entities.Payroll
{
    public class CashFlow :BaseEntity
    {
        public int EmployeeId { get; set; }
        public Decimal DrAmount { get; set; }
        public Decimal CrAmount { get; set; }

        public DateTime Date { get; set; }

        public Employee Employee { get; set; }
    }
}
