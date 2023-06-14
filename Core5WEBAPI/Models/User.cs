using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core5WEBAPI.Models
{
    public class User
    {
        public Guid Guid { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public User()
        {

        }
    }
}
