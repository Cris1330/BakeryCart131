using System;

namespace BakeryCart131.Models
{
    public class User
    {
        public User()
        {
        }

        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }
    }
}
