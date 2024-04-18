using Microsoft.EntityFrameworkCore;
using PhilosopherApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhilosopherApp.Data
{
    public class PhilosopherContext : DbContext
    {
        public DbSet<Philosopher> Philosophers { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = PhilosopherAppData");
        }
    }
}
