using Core5WEBAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly List<User> _users = new List<User>();

        public UsersController()
        {

            _users.Add(new User()
            {
                Email = "john@example.com",
                Name = "John Doe",
                Password = "password123",
                Guid = Guid.NewGuid()
            });

            _users.Add(new User()
            {
                Email = "jane@example.com",
                Name = "Jane Doe",
                Password = "password123",
                Guid = Guid.Parse("587671b5-3c0a-46e9-9015-624220c614ca")
            });

        }

        [HttpGet]
        public ActionResult<List<User>> Index()
        {
            return _users; //returns all users.
        }

        [HttpGet("{guid}")]
        public ActionResult<User> GetByGuid(Guid guid)
        {
            return Ok(_users.FirstOrDefault(u => u.Guid == guid));
        }

        [HttpPost]
        public ActionResult<User> Insert([FromBody] User user)
        {
            _users.Add(user);
            return user;
        }


    }
}
