using Core.Entities.Admin;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IAuthService<User> _authService;
        public TestController(IAuthService<User> authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var user = new User
            {
                CreatedDate = DateTime.Now,
                Email = "kozipan",
                UserName = "slk",
                Name = "Anees",
                UserType = UserType.Admin
            };

            _authService.Create(user, "fucku");
            _authService.UserExists("Selik");

            return null;
        }
     
    }
}
