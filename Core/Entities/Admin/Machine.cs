using Core.Entities.Customers;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Admin
{
    public class Machine :BaseEntity
    {
        public string Name { get; set; }
        public string Key { get; set; }
        public bool isEnabled { get; set; }

        public int BranchId  { get; set; }

        public DeviceType Type { get; set; }

        public bool Enabled { get; set; }

        public Branch Branch { get; set; }

    }


    public enum DeviceType :byte {

        In=1,
        Out=2,
        Non=3

    }
}
