using Core.Entities.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Settings
{
    public class Year :BaseEntity
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public Branch Branch { get; set; }
    }
}
