using Core.Entities.Admin;
using System.Collections;
using System.Collections.Generic;

namespace Core.Entities.Customers
{
    public class Branch :BaseEntity
    {
        public string Name { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
