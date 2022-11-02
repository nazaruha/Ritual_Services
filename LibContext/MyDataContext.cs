using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibContext.Entities;
using Newtonsoft.Json;

namespace LibContext
{
    public class MyDataContext : DbContext // inherites this class to work with DB
    {
        private string dirJson = "json_files";
        public MyDataContext()
        {
            this.Database.Migrate(); // automatically creates migrations
            if (!ServicesTypes.Any())
                InitializeDB();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ServiceType> ServicesTypes { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Integrated Security=True; Initial Catalog=Web-Church");
        }

        private void InitializeDB()
        {
            InitializeServiceTypeTable();
            InitializeServiceTable();
        }

        private void InitializeServiceTypeTable()
        {
            if (ServicesTypes.Any()) return;
            string json = File.ReadAllText($"{dirJson}\\ServicesTypes.json");
            List<ServiceType> services_types = JsonConvert.DeserializeObject<List<ServiceType>>(json);
            foreach (var item in services_types)
            {
                ServicesTypes.Add(item);
            }
            this.SaveChanges();
        }

        private void InitializeServiceTable()
        {
            if (Services.Any()) return;
            string json = File.ReadAllText($"{dirJson}\\Services.json");
            List<Service> services = JsonConvert.DeserializeObject<List<Service>>(json);
            foreach (var item in services)
            {
                Services.Add(item);
            }
            this.SaveChanges();
        }
    }
}
