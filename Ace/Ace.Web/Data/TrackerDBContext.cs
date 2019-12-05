using Ace.Web.Core;
using Microsoft.EntityFrameworkCore;

namespace Ace.Web.Data
{
    public class TrackerDBContext : DbContext
    {
        public DbSet<Step> Steps { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                    .UseSqlServer(@"Data Source=ITS-416957-D\SQLEXPRESS;Initial Catalog=TrackerDB;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}

