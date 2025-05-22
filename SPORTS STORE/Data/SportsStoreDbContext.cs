using Microsoft.EntityFrameworkCore;
using SPORTS_STORE.Models;

namespace SPORTS_STORE.Data  // Must match exactly
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CartLine> CartLines { get; set; }
    }
}