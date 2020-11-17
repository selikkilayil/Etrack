using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Customers
{
    public class Customer :BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }

        public DateTime JoinDate { get; set; }

        public Subscription SubscriptionType { get; set; }

        public ICollection<Branch> Branches { get; set; }
    }

    public enum Subscription : byte
    {
        [Display(Name = "Free For First Year")]
        FirstYearFree = 1,
        [Display(Name = "Yearly")]
        Yearly = 2,
        [Display(Name = "Free Package")]
        Free = 3
    }
}
