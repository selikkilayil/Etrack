using Core.Entities.Customers;
using System;

namespace Core.Entities.Settings
{
    public class LeaveCalender : BaseEntity
    {
        public int YearId { get; set; }

        public int BranchId { get; set; }

        public DateTime Date { get; set; }

        public Branch Branch { get; set; }
    }
}
