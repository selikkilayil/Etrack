using Ardalis.Specification;
using Core.Entities.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public sealed class UserSpecification : Specification<User>
    {
        public UserSpecification(string username)
        {
            Query.Where(x => x.UserName == username);
        }

    }
}
