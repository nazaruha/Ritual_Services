using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApplication
{
    public class User
    {
        private string login, email, pass;
        public int Id { get; set; }
        public string Login { get { return login; } set { email = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public User() { }
        public User(string login, string email, string password)
        {
           // Id = id;
            this.login = login;
            this.email = email;
            this.pass = password;
        }
    }
}
