using Microsoft.EntityFrameworkCore;

namespace GameStore.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}