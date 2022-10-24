using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApplication
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get;}
        public string Email { get;}
        public string Password { get; set; }
        public User() { }
        public User(string login, string email, string password)
        {
            Login = login;
            Email = email;
            Password = password;
        }
    }
}
