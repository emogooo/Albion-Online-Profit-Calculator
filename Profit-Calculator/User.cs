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
            createDate = DateTime.Now;
        }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime createDate { get; }
        public override string ToString()
        {
            return Username + " - " + Email + " - " + Password;
        }
    }
}
