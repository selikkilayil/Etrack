using Core.Entities.Customers;
using System;

namespace Core.Entities.Settings
{
    public class LeaveCalender : BaseEntity
    {
        public int YearId { get; set; }

        public DateTime Date { get; set; }

        public Year Year { get; set; }
    }
}
