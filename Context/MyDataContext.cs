using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Context.Entities;

namespace Context
{
    public class MyDataContext : DbContext // inherites this class to work with DB
    {
        public MyDataContext()
        {
            this.Database.Migrate(); // automatically creates migrations
        }

        DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Integrated Security=True; Initial Catalog=RitualServices");
        }
    }
}
