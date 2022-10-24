using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserApplication
{
    public class ApplicationContext
    {

        public DbSet<User> Users { get; set; }

       // public ApplicationContext() : base("DefaultConnection") { }
    }
}
