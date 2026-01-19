using Microsoft.EntityFrameworkCore;

namespace API_with_EntitiyFramework.Model
{
    public class ShopDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Registered> Registered { get; set; }
        public ShopDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
