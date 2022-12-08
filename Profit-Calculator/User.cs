using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit_Calculator
{
    public class User
    {
        public User() { }
        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            IsApproved = false;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsApproved { get; set; }

        public override string ToString()
        {
            return Username + " - " + Email + " - " + Password + " - " + IsApproved;
        }
    }
}
