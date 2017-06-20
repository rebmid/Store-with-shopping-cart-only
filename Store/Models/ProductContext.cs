using System.Data.Entity;

namespace Store.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("Store")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
