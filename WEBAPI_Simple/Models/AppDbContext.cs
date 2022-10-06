using Microsoft.EntityFrameworkCore;
using WEBAPI_Simple.Models;

namespace webapi_simple.models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductCatViewModel> CatwiseProducts { get; set; }


    }
}
