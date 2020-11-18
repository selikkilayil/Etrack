using Core.Entities.Customers;

namespace Core.Entities.Admin
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public int? BranchId { get; set; }

        public UserType UserType { get; set; }

        public Branch Branch { get; set; }


    }

    public enum UserType : byte
    {
        Admin,
        Staff,
        Employee
    }

}
