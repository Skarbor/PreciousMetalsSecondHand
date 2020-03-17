using Microsoft.EntityFrameworkCore;
using PrecoiusMetalsSecondHand.Data.Entities;

namespace PrecoiusMetalsSecondHand.Data.Context
{
    class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=blogging.db");
        }
    }
}
