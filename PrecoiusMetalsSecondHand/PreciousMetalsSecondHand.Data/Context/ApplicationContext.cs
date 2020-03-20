using Microsoft.EntityFrameworkCore;
using PreciousMetalsSecondHand.Data.Entities;

namespace PreciousMetalsSecondHand.Data.Context
{
    class ApplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductType> Products { get; set; }

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
