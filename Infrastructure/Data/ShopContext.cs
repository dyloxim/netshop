using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public required DbSet<Product> Products { get; set; }
    }
}
