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
        public DbSet<Discussion> Discussions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = PhilosopherAppData");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Philosopher>()
                .HasMany(d => d.Discussions)
                .WithMany(p => p.Philosophers)
                .UsingEntity<DiscussionPhilosopher>
                (dp => dp.HasOne<Discussion>().WithMany(),
                 dp => dp.HasOne<Philosopher>().WithMany())
                .Property(dp => dp.DateJoined)
                .HasDefaultValueSql("getdate()");
        }
    }
}
